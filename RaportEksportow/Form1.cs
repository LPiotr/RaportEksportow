using NLog;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace RaportEksportow
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        private readonly DataClassesDataContext dataContext = new DataClassesDataContext();
        private const int MaxRecordsPerPage = 100;
        private int currentPage = 1;

        public Form1()
        {
            InitializeComponent();

            linqServerModeSource.QueryableSource = dataContext.vw_historia_eksportow;

            gridView1.OptionsBehavior.AutoPopulateColumns = true;
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsView.ShowAutoFilterRow = false;
            gridView1.OptionsView.ShowFooter = false;
            gridView1.OptionsView.ShowGroupPanel = false;

            dateTimePickerFrom.CustomFormat = "yyyy-MM-dd";
            dateTimePickerTo.CustomFormat = "yyyy-MM-dd";
            dateTimePickerFrom.Format = DateTimePickerFormat.Custom;
            dateTimePickerTo.Format = DateTimePickerFormat.Custom;

            LoadComboBoxList();
        }

        private void LoadComboBoxList()
        {
            try
            {
                using (var localDataContext = new DataClassesDataContext())
                {
                    var places = localDataContext.vw_historia_eksportow
                                                .Select(c => c.Lokal)
                                                .Distinct()
                                                .ToList();
                    //wyrazenie lambda, które sortuje listę miejsc po numerze, który jest na końcu nazwy
                    //LINQ - Language Integrated Query
                    // Extension methods - metody rozszerzające
                    var sortedPlaces = places.OrderBy(l => ParseNumber(l)).ToList();

                    comboBox1.DataSource = sortedPlaces;
                }
            }
            catch (SqlException ex)
            {
                logger.Fatal(ex, "Błąd bazy danych");
                MessageBox.Show($"Błąd bazy danych: {ex.Message}");

            }
            catch (Exception ex)
            {
                logger.Error(ex, "Wyjątek");
                MessageBox.Show($"Wyjątek: {ex.Message}");
            }
        }

        private int ParseNumber(string place)
        { 
            var numberPart = place.Split(' ').LastOrDefault();
            return int.TryParse(numberPart, out int number) ? number : 0;
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                LoadPage();
            }
        }

        private IQueryable<vw_historia_eksportow> GetBaseQuery()
        {
            return from c in dataContext.vw_historia_eksportow
                   where c.Data != null
                         && c.Data >= dateTimePickerFrom.Value.Date
                         && c.Data <= dateTimePickerTo.Value.Date
                         && c.Lokal == comboBox1.Text
                   select c;
        }

        private void LoadPage()
        {
            try
            {
                var baseQuery = GetBaseQuery();
                var pagedQuery = baseQuery.Skip((currentPage - 1) * MaxRecordsPerPage)
                                          .Take(MaxRecordsPerPage)
                                          .ToList();

                gridControl1.DataSource = pagedQuery;

                int totalPageCount = GetTotalPageCount(baseQuery);

                lblCurrentPage.Text = $"Strona: {currentPage} z {totalPageCount}";
                btnPrevious.Enabled = currentPage > 1;
                btnNext.Enabled = currentPage < totalPageCount;
            }
            catch (SqlException ex)
            {
                logger.Fatal(ex, "Błąd bazy danych");
                MessageBox.Show($"Błąd bazy danych: {ex.Message}");
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Wyjątek");
                MessageBox.Show($"Wyjątek: {ex.Message}");
            }
        }

        private int GetTotalPageCount(IQueryable<vw_historia_eksportow> baseQuery)
        {
            try
            {
                int totalRecordCount = baseQuery.Count();
                
                return (int)Math.Ceiling((double)totalRecordCount / MaxRecordsPerPage);
            }
            catch (SqlException ex)
            {
                logger.Fatal(ex, "Błąd bazy danych");
                MessageBox.Show($"Błąd bazy danych: {ex.Message}");
                
                return -1;
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Wyjątek");
                MessageBox.Show($"Wyjątek: {ex.Message}");
                
                return -2;
            }
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadPage();
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            currentPage++;
            //paging
            LoadPage();
        }

        private bool ValidateInput()
        {
            if (dateTimePickerFrom.Value.Date > dateTimePickerTo.Value.Date)
            {
                logger.Error("Data początkowa jest późniejsza niż data końcowa");

                MessageBox.Show("\r\nData początkowa musi być wcześniejsza niż data końcowa.", 
                                "Nieprawidłowy zakres dat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            if (comboBox1.SelectedIndex == -1 || comboBox1.Text == string.Empty)
            {
                logger.Error("Nie wybrano 'Lokalu' z listy");

                MessageBox.Show("Proszę wybrać prawidłowy 'Lokal' z listy.",
                    "Wymagany wybór", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //jeśli dane są poprawne, zwracamy true
            //jest spoko
            return true;
        }

        //przesłaniamy metodę OnFormClosing, aby zamknąć połączenie z bazą danych oraz zatrzymać logger
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            dataContext?.Dispose();
            LogManager.Shutdown();
        }
    }
}

