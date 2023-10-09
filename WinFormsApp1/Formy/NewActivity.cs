using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public partial class NewActivity : Form
    {
        public MyContext Context = new MyContext();

        public BindingList<Uzivatel> DataUzivatel = new BindingList<Uzivatel>();
        public BindingList<Projekt> DataProjekt = new BindingList<Projekt>();
        public DateTime StartTime;
        public DateTime EndTime;
        public int citac;

        public NewActivity()
        {
            InitializeComponent();

            foreach (var x in Context.Projekty)
            {
                this.DataProjekt.Add(x);
            }
            this.comboBoxProjekty.DataSource = DataProjekt;
            this.comboBoxProjekty.DisplayMember = "Nazev";
            this.comboBoxProjekty.ValueMember = "Id";
            foreach (var x in Context.Uzivatele)
            {
                this.DataUzivatel.Add(x);
            }
            this.comboBoxUzivatele.DataSource = DataUzivatel;
            this.comboBoxUzivatele.DisplayMember = "Nazev";
            this.comboBoxUzivatele.ValueMember = "Id";
            this.comboBoxUzivatele.SelectedValue = ActiveUser.PrihlasenyUzivatel.Id;
        }

        private void buttonVytvorit_Click(object sender, EventArgs e)
        {
            IsValid();
            if (IsValid() == true)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool IsValid()
        {
            bool valid = true;
            this.errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(this.textBoxPopisCinnosti.Text))
            {
                valid = false;
                this.errorProvider1.SetError(this.textBoxPopisCinnosti, "Pole je povinne");
            }
            if (StartTime == null)
            {
                buttonStartTimer_Click(null, null);
            }
            if (EndTime == null) ;
            {
                buttonPause_Click(null, null);
            }

            return valid;
        }

        private void buttonStartTimer_Click(object sender, EventArgs e)
        {

            if (citac == 0)
            {
                this.StartTime = DateTime.Now;
                this.timer1.Enabled = true;
                citac++;
            }
            else
            {
                this.timer1.Enabled = true;

            }
        }


        public short Hodina, Minuta, Sekunda;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Sekundyadd();
            Reset();
        }
        private void Sekundyadd()
        {
            if (Sekunda == 59)
            {
                Sekunda = 0;
                Minutyadd();
            }
            else
            {
                Sekunda++;
            }
        }
        private void Minutyadd()
        {
            if (Minuta == 59)
            {
                Minuta = 0;
                Hodinyadd();
            }
            else
            {
                Minuta++;
            }
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void buttonResetTime_Click(object sender, EventArgs e)
        {
            this.timer1.Enabled = false;
            Hodina = 0;
            Minuta = 0;
            Sekunda = 0;
            citac = 0;
            Reset();
        }

        private void Hodinyadd()
        {
            Hodina++;
        }
        private void Reset()
        {
            LabelHours.Text = Hodina.ToString("00");
            LabelMinutes.Text = Minuta.ToString("00");
            LabelSeconds.Text = Sekunda.ToString("00");
        }
      
    }
}
