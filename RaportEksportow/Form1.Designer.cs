namespace RaportEksportow
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.linqServerModeSource = new DevExpress.Data.Linq.LinqServerModeSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNazwa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colData = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGodzina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUżytkownik = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLokal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.applyButton = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblCurrentPage = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.linqServerModeSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePickerFrom.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.dateTimePickerFrom.Location = new System.Drawing.Point(34, 62);
            this.dateTimePickerFrom.Name = "dateTimePicker1";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(121, 22);
            this.dateTimePickerFrom.TabIndex = 0;
            // 
            // dateTimePicker2
            // 
            this.dateTimePickerTo.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.dateTimePickerTo.Location = new System.Drawing.Point(34, 102);
            this.dateTimePickerTo.Name = "dateTimePicker2";
            this.dateTimePickerTo.Size = new System.Drawing.Size(121, 22);
            this.dateTimePickerTo.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 9.25F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(34, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 22);
            this.comboBox1.TabIndex = 2;
            // 
            // linqServerModeSource
            // 
            this.linqServerModeSource.KeyExpression = "id";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNazwa,
            this.colData,
            this.colGodzina,
            this.colUżytkownik,
            this.colLokal});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowFilter = false;
            // 
            // colNazwa
            // 
            this.colNazwa.FieldName = "Nazwa";
            this.colNazwa.Name = "colNazwa";
            this.colNazwa.Visible = true;
            this.colNazwa.VisibleIndex = 0;
            // 
            // colData
            // 
            this.colData.FieldName = "Data";
            this.colData.Name = "colData";
            this.colData.Visible = true;
            this.colData.VisibleIndex = 1;
            // 
            // colGodzina
            // 
            this.colGodzina.FieldName = "Godzina";
            this.colGodzina.Name = "colGodzina";
            this.colGodzina.Visible = true;
            this.colGodzina.VisibleIndex = 2;
            // 
            // colUżytkownik
            // 
            this.colUżytkownik.FieldName = "Użytkownik";
            this.colUżytkownik.Name = "colUżytkownik";
            this.colUżytkownik.Visible = true;
            this.colUżytkownik.VisibleIndex = 3;
            // 
            // colLokal
            // 
            this.colLokal.FieldName = "Lokal";
            this.colLokal.Name = "colLokal";
            this.colLokal.Visible = true;
            this.colLokal.VisibleIndex = 4;
            // 
            // gridControl1
            // 
            this.gridControl1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.gridControl1.Location = new System.Drawing.Point(287, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(683, 485);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // applyButton
            // 
            this.applyButton.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.applyButton.Appearance.Options.UseFont = true;
            this.applyButton.Location = new System.Drawing.Point(34, 511);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(157, 39);
            this.applyButton.TabIndex = 4;
            this.applyButton.Text = "Zatwierdź";
            this.applyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.btnPrevious.Location = new System.Drawing.Point(287, 508);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(156, 42);
            this.btnPrevious.TabIndex = 5;
            this.btnPrevious.Text = "Poprzednia strona";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.btnNext.Location = new System.Drawing.Point(817, 508);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(153, 42);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Następna strona";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // lblCurrentPage
            // 
            this.lblCurrentPage.Appearance.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.lblCurrentPage.Appearance.Options.UseFont = true;
            this.lblCurrentPage.Location = new System.Drawing.Point(593, 521);
            this.lblCurrentPage.Name = "lblCurrentPage";
            this.lblCurrentPage.Size = new System.Drawing.Size(5, 17);
            this.lblCurrentPage.TabIndex = 7;
            this.lblCurrentPage.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 573);
            this.Controls.Add(this.lblCurrentPage);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.linqServerModeSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.ComboBox comboBox1;
        private DevExpress.Data.Linq.LinqServerModeSource linqServerModeSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colNazwa;
        private DevExpress.XtraGrid.Columns.GridColumn colData;
        private DevExpress.XtraGrid.Columns.GridColumn colGodzina;
        private DevExpress.XtraGrid.Columns.GridColumn colUżytkownik;
        private DevExpress.XtraGrid.Columns.GridColumn colLokal;
        private DevExpress.XtraEditors.SimpleButton applyButton;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private DevExpress.XtraEditors.LabelControl lblCurrentPage;
    }
}

