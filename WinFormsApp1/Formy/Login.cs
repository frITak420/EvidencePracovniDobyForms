using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsApp1
{
    public partial class Login : Form
    {
        public List<Uzivatel> uzivatel=new List<Uzivatel>();
        public MyContext context=new MyContext();
       
        public string PrihlJmeno { get; set; }
        
        public Login()
        {
            InitializeComponent();
            textBoxPassword.PasswordChar = '*';
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            foreach (Uzivatel item in context.Uzivatele)
            {
                if (item.PrihlasovaciJmeno==textBoxLoginName.Text&&item.Heslo==textBoxPassword.Text)
                {
                    MessageBox.Show("Úspěšne jsi se přihlásil");
                    ActiveUser.PrihlasenyUzivatel = item;
                    Main form = new Main();
                    this.Hide();
                    form.ShowDialog();
                }
            }

        }
    }
}
