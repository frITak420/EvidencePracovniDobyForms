namespace WinFormsApp1
{
    partial class NewActivity
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
            components = new System.ComponentModel.Container();
            label1 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            textBoxPopisCinnosti = new System.Windows.Forms.TextBox();
            buttonVytvorit = new System.Windows.Forms.Button();
            timer1 = new System.Windows.Forms.Timer(components);
            buttonStartTimer = new System.Windows.Forms.Button();
            buttonResetTime = new System.Windows.Forms.Button();
            checkBoxChooseTime = new System.Windows.Forms.CheckBox();
            maskedTextBoxZacatek = new System.Windows.Forms.MaskedTextBox();
            maskedTextBoxKonec = new System.Windows.Forms.MaskedTextBox();
            comboBoxUzivatele = new System.Windows.Forms.ComboBox();
            comboBoxProjekty = new System.Windows.Forms.ComboBox();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            LabelHours = new System.Windows.Forms.Label();
            LabelMinutes = new System.Windows.Forms.Label();
            LabelSeconds = new System.Windows.Forms.Label();
            buttonPause = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(29, 20);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(105, 21);
            label1.TabIndex = 0;
            label1.Text = "Popis cinnosti";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(30, 61);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(59, 21);
            label4.TabIndex = 3;
            label4.Text = "Projekt";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(30, 95);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(65, 21);
            label5.TabIndex = 4;
            label5.Text = "Uživatel";
            // 
            // textBoxPopisCinnosti
            // 
            textBoxPopisCinnosti.BackColor = System.Drawing.Color.Bisque;
            textBoxPopisCinnosti.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxPopisCinnosti.Location = new System.Drawing.Point(133, 18);
            textBoxPopisCinnosti.Name = "textBoxPopisCinnosti";
            textBoxPopisCinnosti.Size = new System.Drawing.Size(182, 27);
            textBoxPopisCinnosti.TabIndex = 5;
            // 
            // buttonVytvorit
            // 
            buttonVytvorit.BackColor = System.Drawing.Color.Bisque;
            buttonVytvorit.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            buttonVytvorit.Location = new System.Drawing.Point(66, 233);
            buttonVytvorit.Name = "buttonVytvorit";
            buttonVytvorit.Size = new System.Drawing.Size(191, 70);
            buttonVytvorit.TabIndex = 10;
            buttonVytvorit.Text = "Vytvořit";
            buttonVytvorit.UseVisualStyleBackColor = false;
            buttonVytvorit.Click += buttonVytvorit_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // buttonStartTimer
            // 
            buttonStartTimer.BackColor = System.Drawing.Color.Bisque;
            buttonStartTimer.Location = new System.Drawing.Point(28, 188);
            buttonStartTimer.Name = "buttonStartTimer";
            buttonStartTimer.Size = new System.Drawing.Size(49, 27);
            buttonStartTimer.TabIndex = 17;
            buttonStartTimer.Text = "Start";
            buttonStartTimer.UseVisualStyleBackColor = false;
            buttonStartTimer.Click += buttonStartTimer_Click;
            // 
            // buttonResetTime
            // 
            buttonResetTime.BackColor = System.Drawing.Color.Bisque;
            buttonResetTime.Location = new System.Drawing.Point(166, 188);
            buttonResetTime.Name = "buttonResetTime";
            buttonResetTime.Size = new System.Drawing.Size(49, 27);
            buttonResetTime.TabIndex = 18;
            buttonResetTime.Text = "Reset";
            buttonResetTime.UseVisualStyleBackColor = false;
            buttonResetTime.Click += buttonResetTime_Click;
            // 
            // checkBoxChooseTime
            // 
            checkBoxChooseTime.AutoSize = true;
            checkBoxChooseTime.Location = new System.Drawing.Point(230, 136);
            checkBoxChooseTime.Name = "checkBoxChooseTime";
            checkBoxChooseTime.Size = new System.Drawing.Size(93, 19);
            checkBoxChooseTime.TabIndex = 19;
            checkBoxChooseTime.Text = "Vybrat ručně";
            checkBoxChooseTime.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxZacatek
            // 
            maskedTextBoxZacatek.BackColor = System.Drawing.Color.Bisque;
            maskedTextBoxZacatek.Location = new System.Drawing.Point(230, 161);
            maskedTextBoxZacatek.Mask = "00:00";
            maskedTextBoxZacatek.Name = "maskedTextBoxZacatek";
            maskedTextBoxZacatek.Size = new System.Drawing.Size(55, 23);
            maskedTextBoxZacatek.TabIndex = 22;
            // 
            // maskedTextBoxKonec
            // 
            maskedTextBoxKonec.BackColor = System.Drawing.Color.Bisque;
            maskedTextBoxKonec.Location = new System.Drawing.Point(229, 190);
            maskedTextBoxKonec.Mask = "00:00";
            maskedTextBoxKonec.Name = "maskedTextBoxKonec";
            maskedTextBoxKonec.Size = new System.Drawing.Size(56, 23);
            maskedTextBoxKonec.TabIndex = 23;
            // 
            // comboBoxUzivatele
            // 
            comboBoxUzivatele.BackColor = System.Drawing.Color.Bisque;
            comboBoxUzivatele.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxUzivatele.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            comboBoxUzivatele.FormattingEnabled = true;
            comboBoxUzivatele.Location = new System.Drawing.Point(133, 93);
            comboBoxUzivatele.Name = "comboBoxUzivatele";
            comboBoxUzivatele.Size = new System.Drawing.Size(182, 28);
            comboBoxUzivatele.TabIndex = 24;
            // 
            // comboBoxProjekty
            // 
            comboBoxProjekty.BackColor = System.Drawing.Color.Bisque;
            comboBoxProjekty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxProjekty.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            comboBoxProjekty.FormattingEnabled = true;
            comboBoxProjekty.Location = new System.Drawing.Point(133, 59);
            comboBoxProjekty.Name = "comboBoxProjekty";
            comboBoxProjekty.Size = new System.Drawing.Size(182, 28);
            comboBoxProjekty.TabIndex = 25;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // LabelHours
            // 
            LabelHours.AutoSize = true;
            LabelHours.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LabelHours.Location = new System.Drawing.Point(29, 136);
            LabelHours.Name = "LabelHours";
            LabelHours.Size = new System.Drawing.Size(58, 47);
            LabelHours.TabIndex = 26;
            LabelHours.Text = "00";
            // 
            // LabelMinutes
            // 
            LabelMinutes.AutoSize = true;
            LabelMinutes.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LabelMinutes.Location = new System.Drawing.Point(97, 136);
            LabelMinutes.Name = "LabelMinutes";
            LabelMinutes.Size = new System.Drawing.Size(58, 47);
            LabelMinutes.TabIndex = 27;
            LabelMinutes.Text = "00";
            // 
            // LabelSeconds
            // 
            LabelSeconds.AutoSize = true;
            LabelSeconds.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LabelSeconds.Location = new System.Drawing.Point(165, 136);
            LabelSeconds.Name = "LabelSeconds";
            LabelSeconds.Size = new System.Drawing.Size(58, 47);
            LabelSeconds.TabIndex = 28;
            LabelSeconds.Text = "00";
            // 
            // buttonPause
            // 
            buttonPause.BackColor = System.Drawing.Color.Bisque;
            buttonPause.Location = new System.Drawing.Point(97, 188);
            buttonPause.Name = "buttonPause";
            buttonPause.Size = new System.Drawing.Size(49, 27);
            buttonPause.TabIndex = 29;
            buttonPause.Text = "Pause";
            buttonPause.UseVisualStyleBackColor = false;
            buttonPause.Click += buttonPause_Click;
            // 
            // NewCinnost
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.SandyBrown;
            ClientSize = new System.Drawing.Size(352, 339);
            Controls.Add(buttonPause);
            Controls.Add(LabelSeconds);
            Controls.Add(LabelMinutes);
            Controls.Add(LabelHours);
            Controls.Add(comboBoxProjekty);
            Controls.Add(comboBoxUzivatele);
            Controls.Add(maskedTextBoxKonec);
            Controls.Add(maskedTextBoxZacatek);
            Controls.Add(checkBoxChooseTime);
            Controls.Add(buttonResetTime);
            Controls.Add(buttonStartTimer);
            Controls.Add(buttonVytvorit);
            Controls.Add(textBoxPopisCinnosti);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "NewCinnost";
            Text = "NewCinnost";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonVytvorit;
        public System.Windows.Forms.TextBox textBoxPopisCinnosti;
        public System.Windows.Forms.ComboBox comboBoxProjekt;
        public System.Windows.Forms.ComboBox comboBoxUzivatel;




        private System.Windows.Forms.Button buttonStartTimer;
        private System.Windows.Forms.Button buttonResetTime;
        public System.Windows.Forms.CheckBox checkBoxChooseTime;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.MaskedTextBox maskedTextBoxZacatek;
        public System.Windows.Forms.MaskedTextBox maskedTextBoxKonec;
        public System.Windows.Forms.ComboBox comboBoxUzivatele;
        public System.Windows.Forms.ComboBox comboBoxProjekty;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label LabelSeconds;
        private System.Windows.Forms.Label LabelMinutes;
        private System.Windows.Forms.Label LabelHours;
        private System.Windows.Forms.Button buttonPause;
    }
}