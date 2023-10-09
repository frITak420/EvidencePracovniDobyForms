namespace WinFormsApp1
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.zákazníciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonPridatProjekt = new System.Windows.Forms.Button();
            this.buttonNovaCinnost = new System.Windows.Forms.Button();
            this.buttonPridatZakaznika = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonExportDetail = new System.Windows.Forms.Button();
            this.comboBoxMonths = new System.Windows.Forms.ComboBox();
            this.buttonExportSouhr = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SandyBrown;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.zákazníciToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(678, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(62, 20);
            this.toolStripMenuItem1.Text = "Projekty";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(113, 20);
            this.toolStripMenuItem2.Text = "Zobrazení čnností";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(121, 20);
            this.toolStripMenuItem3.Text = "Zobrazení uživatelů";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // zákazníciToolStripMenuItem
            // 
            this.zákazníciToolStripMenuItem.Name = "zákazníciToolStripMenuItem";
            this.zákazníciToolStripMenuItem.Size = new System.Drawing.Size(125, 20);
            this.zákazníciToolStripMenuItem.Text = "Zobrazení zákazníků";
            this.zákazníciToolStripMenuItem.Click += new System.EventHandler(this.zákazníciToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Wheat;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(412, 350);
            this.dataGridView1.TabIndex = 1;
            // 
            // buttonPridatProjekt
            // 
            this.buttonPridatProjekt.BackColor = System.Drawing.Color.Bisque;
            this.buttonPridatProjekt.Location = new System.Drawing.Point(36, 3);
            this.buttonPridatProjekt.Name = "buttonPridatProjekt";
            this.buttonPridatProjekt.Size = new System.Drawing.Size(143, 41);
            this.buttonPridatProjekt.TabIndex = 2;
            this.buttonPridatProjekt.Text = "Přidat Projekt";
            this.buttonPridatProjekt.UseVisualStyleBackColor = false;
            this.buttonPridatProjekt.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonNovaCinnost
            // 
            this.buttonNovaCinnost.BackColor = System.Drawing.Color.Bisque;
            this.buttonNovaCinnost.Location = new System.Drawing.Point(36, 97);
            this.buttonNovaCinnost.Name = "buttonNovaCinnost";
            this.buttonNovaCinnost.Size = new System.Drawing.Size(143, 41);
            this.buttonNovaCinnost.TabIndex = 3;
            this.buttonNovaCinnost.Text = "Pokračovat v projektu";
            this.buttonNovaCinnost.UseVisualStyleBackColor = false;
            this.buttonNovaCinnost.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonPridatZakaznika
            // 
            this.buttonPridatZakaznika.BackColor = System.Drawing.Color.Bisque;
            this.buttonPridatZakaznika.Location = new System.Drawing.Point(36, 50);
            this.buttonPridatZakaznika.Name = "buttonPridatZakaznika";
            this.buttonPridatZakaznika.Size = new System.Drawing.Size(143, 41);
            this.buttonPridatZakaznika.TabIndex = 4;
            this.buttonPridatZakaznika.Text = "Přidat zákazníka";
            this.buttonPridatZakaznika.UseVisualStyleBackColor = false;
            this.buttonPridatZakaznika.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.Bisque;
            this.buttonRefresh.Location = new System.Drawing.Point(165, 152);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(55, 23);
            this.buttonRefresh.TabIndex = 5;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Visible = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.buttonPridatProjekt);
            this.panel1.Controls.Add(this.buttonPridatZakaznika);
            this.panel1.Controls.Add(this.buttonRefresh);
            this.panel1.Controls.Add(this.buttonNovaCinnost);
            this.panel1.Location = new System.Drawing.Point(446, 218);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 175);
            this.panel1.TabIndex = 6;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Bisque;
            this.buttonDelete.Location = new System.Drawing.Point(36, 145);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Odstranit";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonExportDetail
            // 
            this.buttonExportDetail.BackColor = System.Drawing.Color.Bisque;
            this.buttonExportDetail.Location = new System.Drawing.Point(36, 4);
            this.buttonExportDetail.Name = "buttonExportDetail";
            this.buttonExportDetail.Size = new System.Drawing.Size(143, 39);
            this.buttonExportDetail.TabIndex = 2;
            this.buttonExportDetail.Text = "Detailní export";
            this.buttonExportDetail.UseVisualStyleBackColor = false;
            this.buttonExportDetail.Click += new System.EventHandler(this.buttonExportDetail_Click);
            // 
            // comboBoxMonths
            // 
            this.comboBoxMonths.BackColor = System.Drawing.Color.Bisque;
            this.comboBoxMonths.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMonths.FormattingEnabled = true;
            this.comboBoxMonths.Items.AddRange(new object[] {
            "Leden",
            "Únor",
            "Březen",
            "Duben",
            "Květen",
            "Červen",
            "Červenec",
            "Srpen",
            "Září",
            "Říjen",
            "Listopad",
            "Prosinec"});
            this.comboBoxMonths.Location = new System.Drawing.Point(36, 96);
            this.comboBoxMonths.Name = "comboBoxMonths";
            this.comboBoxMonths.Size = new System.Drawing.Size(143, 23);
            this.comboBoxMonths.TabIndex = 1;
            // 
            // buttonExportSouhr
            // 
            this.buttonExportSouhr.BackColor = System.Drawing.Color.Bisque;
            this.buttonExportSouhr.Location = new System.Drawing.Point(36, 50);
            this.buttonExportSouhr.Name = "buttonExportSouhr";
            this.buttonExportSouhr.Size = new System.Drawing.Size(143, 39);
            this.buttonExportSouhr.TabIndex = 0;
            this.buttonExportSouhr.Text = "Souhrnný export";
            this.buttonExportSouhr.UseVisualStyleBackColor = false;
            this.buttonExportSouhr.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SandyBrown;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.buttonExportDetail);
            this.panel2.Controls.Add(this.buttonExportSouhr);
            this.panel2.Controls.Add(this.comboBoxMonths);
            this.panel2.Location = new System.Drawing.Point(446, 43);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel2.Size = new System.Drawing.Size(220, 136);
            this.panel2.TabIndex = 7;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(678, 417);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem zákazníciToolStripMenuItem;
        private System.Windows.Forms.Button buttonPridatProjekt;
        private System.Windows.Forms.Button buttonNovaCinnost;
        private System.Windows.Forms.Button buttonPridatZakaznika;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonExportSouhr;
        public System.Windows.Forms.ComboBox comboBoxMonths;
        private System.Windows.Forms.Button buttonExportDetail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonDelete;
    }
}