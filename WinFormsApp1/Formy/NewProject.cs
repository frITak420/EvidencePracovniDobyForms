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
    public partial class NewProject : Form
    {
        MyContext Context=new MyContext();
        
        public BindingList<Zakaznik> DataZakaznik = new BindingList<Zakaznik>();
        public NewProject()
        {
            InitializeComponent();
            foreach (var x in Context.Zakaznici)
            {
                this.DataZakaznik.Add(x);
            }

            this.comboBoxZakaznici.DataSource = DataZakaznik;
            this.comboBoxZakaznici.DisplayMember = "Nazev";
            this.comboBoxZakaznici.ValueMember = "Id";


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

            if (string.IsNullOrWhiteSpace(this.textBoxProjektNazev.Text))
            {
                valid = false;
                this.errorProvider1.SetError(this.textBoxProjektNazev, "Pole je povinne");
            }
            if (!Regex.IsMatch(this.textBoxProjektHodinovaSazba.Text,@"[0-9]"))
            {
                valid = false;
                this.errorProvider1.SetError(this.textBoxProjektHodinovaSazba, "Zadejte číslo");
            }
            return valid;
        }


    }
}
