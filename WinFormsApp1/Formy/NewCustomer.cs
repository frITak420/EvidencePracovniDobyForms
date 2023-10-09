using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class NewCustomer : Form
    {
        public NewCustomer()
        {
            InitializeComponent();
        }

        private void buttonVytvorit_Click(object sender, EventArgs e)
        {
            IsValid();
            if (IsValid() == true)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }
        private bool IsValid()
        {
            bool valid = true;
            this.errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(this.textBoxZakaznikNazev.Text))
            {
                valid = false;
                this.errorProvider1.SetError(this.textBoxZakaznikNazev, "Pole je povinne");
            }

            if (string.IsNullOrWhiteSpace(this.textBoxZakaznikUlice.Text))
            {
                valid = false;
                this.errorProvider1.SetError(this.textBoxZakaznikUlice, "Pole je povinne");
            }

            if (string.IsNullOrWhiteSpace(this.textBoxZakaznikMesto.Text))
            {
                valid = false;
                this.errorProvider1.SetError(this.textBoxZakaznikMesto, "Pole je povinne");
            }
            if (!Regex.IsMatch(this.textBoxZakaznikPSC.Text, @"^[0-9]{3} [0-9]{2}$"))
            {
                valid = false;
                this.errorProvider1.SetError(this.textBoxZakaznikPSC, "Musí být ve formátu:111 11");
            }
            if (!Regex.IsMatch(this.textBoxZakaznikIC.Text, @"^[0-9]{8}"))
            {
                valid = false;
                this.errorProvider1.SetError(this.textBoxZakaznikIC, "Musí být ve formátu:11111111");
            }
            if (!Regex.IsMatch(this.textBoxZakaznikDIC.Text, @"^CZ[0-9]{8}"))
            {
                valid = false;
                this.errorProvider1.SetError(this.textBoxZakaznikIC, "Musí být ve formátu:CZ11111111");
            }

            return valid;
        }


    }
}
