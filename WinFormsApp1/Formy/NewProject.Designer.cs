namespace WinFormsApp1
{
    partial class NewProject
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxProjektNazev = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxProjektHodinovaSazba = new System.Windows.Forms.TextBox();
            this.buttonVytvorit = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxZakaznici = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(83, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Projekt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Název";
            // 
            // textBoxProjektNazev
            // 
            this.textBoxProjektNazev.BackColor = System.Drawing.Color.Bisque;
            this.textBoxProjektNazev.Location = new System.Drawing.Point(164, 79);
            this.textBoxProjektNazev.Name = "textBoxProjektNazev";
            this.textBoxProjektNazev.Size = new System.Drawing.Size(119, 23);
            this.textBoxProjektNazev.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hodinová sazba";
            // 
            // textBoxProjektHodinovaSazba
            // 
            this.textBoxProjektHodinovaSazba.BackColor = System.Drawing.Color.Bisque;
            this.textBoxProjektHodinovaSazba.Location = new System.Drawing.Point(164, 118);
            this.textBoxProjektHodinovaSazba.Name = "textBoxProjektHodinovaSazba";
            this.textBoxProjektHodinovaSazba.Size = new System.Drawing.Size(119, 23);
            this.textBoxProjektHodinovaSazba.TabIndex = 4;
            // 
            // buttonVytvorit
            // 
            this.buttonVytvorit.BackColor = System.Drawing.Color.Bisque;
            this.buttonVytvorit.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonVytvorit.Location = new System.Drawing.Point(34, 193);
            this.buttonVytvorit.Name = "buttonVytvorit";
            this.buttonVytvorit.Size = new System.Drawing.Size(242, 74);
            this.buttonVytvorit.TabIndex = 18;
            this.buttonVytvorit.Text = "Vytvořit";
            this.buttonVytvorit.UseVisualStyleBackColor = false;
            this.buttonVytvorit.Click += new System.EventHandler(this.buttonVytvorit_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 15);
            this.label11.TabIndex = 20;
            this.label11.Text = "Zákazník";
            // 
            // comboBoxZakaznici
            // 
            this.comboBoxZakaznici.BackColor = System.Drawing.Color.Bisque;
            this.comboBoxZakaznici.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxZakaznici.FormattingEnabled = true;
            this.comboBoxZakaznici.Location = new System.Drawing.Point(164, 151);
            this.comboBoxZakaznici.Name = "comboBoxZakaznici";
            this.comboBoxZakaznici.Size = new System.Drawing.Size(119, 23);
            this.comboBoxZakaznici.TabIndex = 23;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // NewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(334, 308);
            this.Controls.Add(this.comboBoxZakaznici);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.buttonVytvorit);
            this.Controls.Add(this.textBoxProjektHodinovaSazba);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxProjektNazev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewProject";
            this.Text = "NewProject";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonVytvorit;
        public System.Windows.Forms.TextBox textBoxProjektNazev;
        public System.Windows.Forms.TextBox textBoxProjektHodinovaSazba;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.ComboBox comboBoxZakaznici;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}