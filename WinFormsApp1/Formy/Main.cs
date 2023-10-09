using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsApp1
{
    public partial class Main : Form
    {
        public BindingList<Projekt> DataProjekt = new BindingList<Projekt>();
        public BindingList<Cinnost> DataCinnost = new BindingList<Cinnost>();
        public BindingList<Zakaznik> DataZakaznik = new BindingList<Zakaznik>();
        public BindingList<Uzivatel> DataUzivatel = new BindingList<Uzivatel>();
        public MyContext Context = new MyContext();
        public int CelkovaCenaProjektu { get; set; }
        public int CelkemHodinProjektu { get; set; }
        public int CelkemMinutProjektu { get; set; }
        public int CelkemSekundProjektu { get; set; }
        public DateTime date { get; set; }
        public int IndexMonth { get; set; }

        public Main()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = DataProjekt;

            foreach (var x in Context.Projekty)
            {
                this.DataProjekt.Add(x);
            }
            this.dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.Columns[3].Visible = false;
            IndexMonth = DateTime.Now.Month;
            this.comboBoxMonths.SelectedIndex = IndexMonth-1;
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = DataProjekt;
            dataGridView1.Rows.Clear();

            this.dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.Columns[3].Visible = false;
            foreach (var x in Context.Projekty)
            {
                this.DataProjekt.Add(x);
            }

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = DataCinnost;
            dataGridView1.Rows.Clear();
            this.dataGridView1.Columns[4].Visible = false;
            this.dataGridView1.Columns[5].Visible = false;
            foreach (var x in Context.Cinnosti)
            {
                this.DataCinnost.Add(x);
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = DataUzivatel;
            dataGridView1.Rows.Clear();
            this.dataGridView1.Columns[4].Visible = false;
            foreach (var x in Context.Uzivatele)
            {
                this.DataUzivatel.Add(x);
            }
        }

        private void zákazníciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = DataZakaznik;
            dataGridView1.Rows.Clear();
            foreach (var x in Context.Zakaznici)
            {
                this.DataZakaznik.Add(x);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            NewProject form = new NewProject();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                Projekt NovyProjekt = new Projekt();
                NovyProjekt.Nazev = form.textBoxProjektNazev.Text;
                NovyProjekt.HodinovaSazba = Convert.ToInt32(form.textBoxProjektHodinovaSazba.Text);
                NovyProjekt.IdZakaznik = Convert.ToInt32(form.comboBoxZakaznici.SelectedValue);


                this.Context.Projekty.Add(NovyProjekt);
                this.Context.SaveChanges();
            }
            buttonRefresh_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NewCustomer form = new NewCustomer();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                Zakaznik NovyZakaznik = new Zakaznik();
                NovyZakaznik.Nazev = form.textBoxZakaznikNazev.Text;
                NovyZakaznik.Ulice = form.textBoxZakaznikUlice.Text;
                NovyZakaznik.Mesto = form.textBoxZakaznikMesto.Text;
                NovyZakaznik.PSC = form.textBoxZakaznikPSC.Text;
                NovyZakaznik.IC = form.textBoxZakaznikIC.Text;
                NovyZakaznik.DIC = form.textBoxZakaznikDIC.Text;
                this.Context.Zakaznici.Add(NovyZakaznik);
                Context.SaveChanges();
            }
            buttonRefresh_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewActivity form = new NewActivity();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                Cinnost NovaCinnost = new Cinnost();
                NovaCinnost.PopisCinnosti = form.textBoxPopisCinnosti.Text;
                if (!form.checkBoxChooseTime.Checked)
                {
                    
                    NovaCinnost.Zacatek = form.StartTime;
                    form.EndTime = form.StartTime.AddHours(form.Hodina);
                    form.EndTime = form.StartTime.AddMinutes(form.Minuta);
                    form.EndTime = form.StartTime.AddSeconds(form.Sekunda);
                    NovaCinnost.Konec = form.EndTime;
                }
                else
                {
                    NovaCinnost.Zacatek = DateTime.Parse(form.maskedTextBoxZacatek.Text);
                    NovaCinnost.Konec = DateTime.Parse(form.maskedTextBoxKonec.Text);
                }

                NovaCinnost.IdProjekt = Convert.ToInt32(form.comboBoxProjekty.SelectedValue);
                NovaCinnost.IdUzivatel = Convert.ToInt32(form.comboBoxUzivatele.SelectedValue);
                this.Context.Cinnosti.Add(NovaCinnost);
                this.Context.SaveChanges();
            }
            buttonRefresh_Click(sender, e);
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.DataSource == DataProjekt)
            {
                toolStripMenuItem1_Click(sender, e);
            }
            if (this.dataGridView1.DataSource == DataUzivatel)
            {
                toolStripMenuItem3_Click(sender, e);
            }
            if (this.dataGridView1.DataSource == DataCinnost)
            {
                toolStripMenuItem2_Click(sender, e);
            }
            if (this.dataGridView1.DataSource == DataZakaznik)
            {
                zákazníciToolStripMenuItem_Click(sender, e);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            SaveFileDialog save = new SaveFileDialog();

            int citac = 0;
            if (save.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("Akce zrušena");
                return;
            }
            sb.Append("<title>Souhrnný export</title>");
            sb.Append("<h1 style='color:black';>Souhrnný export</h1>");
            DateTime Actual = DateTime.Now;

            var firstDayOfMonth = new DateTime(Actual.Year, Actual.Month, 1);
            
            int index = comboBoxMonths.SelectedIndex;

            date = new DateTime(Actual.Year, 1, 1);
            for (int i = 1; i <= 12; i++)
            {
                if (index == i)
                {
                    date = date.AddMonths(index);
                    firstDayOfMonth = new DateTime(Actual.Year, date.Month, 1);
                }
            }
            //}
            var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
            sb.Append("<h3>" + firstDayOfMonth + "-" + lastDayOfMonth + "</h3>");

            foreach (var z in Context.Zakaznici.ToList())
            {
                sb.Append("<h1>" + z.Nazev + "</h1>");

                TimeSpan casCelkem = new();
                int cenaCelkem = 0;

                foreach (var p in Context.Projekty.ToList().Where(x => x.IdZakaznik == z.Id))
                {
                    CelkovaCenaProjektu = 0;
                    CelkemHodinProjektu = 0;
                    CelkemMinutProjektu = 0;
                    CelkemSekundProjektu = 0;

                    sb.Append("<h2>" + p.Nazev + "</h2>");
                    sb.Append("<table>");
                    sb.Append("<tr><th>Činnost</th><th>Doba</th><th>Cena</th></tr>");

                    foreach (var c in Context.Cinnosti.ToList().Where(x => x.IdProjekt == p.Id))
                    {
                        if (c.Zacatek.Month == date.Month)
                        {

                            int CasZacatek = Convert.ToInt32(c.Zacatek.Hour) * 3600 + Convert.ToInt32(c.Zacatek.Minute) * 60 + Convert.ToInt32(c.Zacatek.Second); 
                            int CasKonec = Convert.ToInt32(c.Konec.Hour) * 3600 + Convert.ToInt32(c.Konec.Minute) * 60 + Convert.ToInt32(c.Konec.Second);

                            int vysledek = CasZacatek - CasKonec;

                            int hodina = vysledek / 3600;

                            int PomocnaCena = vysledek / 3600;

                            hodina = (int)Math.Floor(Convert.ToDecimal(hodina));

                            int vyslednaHodina = Math.Abs((int)Math.Floor(Convert.ToDecimal(hodina)));

                            int minuta = (vysledek - (hodina * 3600)) / 60;
                            minuta = (int)Math.Floor(Convert.ToDecimal(minuta));

                            int vyslednaMinuta = Math.Abs((int)Math.Floor(Convert.ToDecimal(minuta)));
                            int sekunda = (vysledek - ((hodina * 3600) + (minuta * 60)));

                            sekunda = Math.Abs(sekunda);
                            int VyslednaCena = Math.Abs(PomocnaCena * Convert.ToInt32(p.HodinovaSazba));

                            sb.Append("<tr><td>" + c.PopisCinnosti + "</td><td>" + vyslednaHodina + ":" + vyslednaMinuta + ":" + sekunda + "</td><td>" + VyslednaCena + "Kč</td></tr>");

                            CelkovaCenaProjektu += VyslednaCena;
                            CelkemHodinProjektu += vyslednaHodina;
                            CelkemMinutProjektu += vyslednaMinuta;
                            CelkemSekundProjektu += sekunda;

                            if (CelkemMinutProjektu > 59)
                            {
                                int CelkemHodinNavic = (int)Math.Floor(Convert.ToDecimal(CelkemMinutProjektu / 60));
                                int CelkemZbyvajicichMinut = CelkemMinutProjektu - (CelkemHodinNavic * 60);
                                CelkemHodinProjektu = +CelkemHodinNavic;
                                CelkemMinutProjektu = CelkemZbyvajicichMinut;
                            }

                            if (CelkemSekundProjektu > 59)
                            {
                                int CelkemMinutNavic = (int)Math.Floor(Convert.ToDecimal(CelkemSekundProjektu / 60));
                                int CelkemZbyvajicichSekund = CelkemSekundProjektu - (CelkemMinutNavic * 60);
                                CelkemMinutProjektu = +CelkemMinutNavic;
                                CelkemSekundProjektu = CelkemZbyvajicichSekund;
                            }

                            casCelkem += (c.Konec - c.Zacatek);

                            cenaCelkem += VyslednaCena;

                        }
                        if (c == Context.Cinnosti.ToList().Last())
                        {
                            sb.Append("<tr><td>Celkem</td><td>" + this.CelkemHodinProjektu + ":" + this.CelkemMinutProjektu + ":" + this.CelkemSekundProjektu + "</td><td>" + this.CelkovaCenaProjektu + "Kč</td></tr>");
                        }

                    }
                    sb.Append("</table>");
                }

                sb.AppendLine("Celkem cena : " + cenaCelkem.ToString() + " Kč");
                sb.Append("Celkem cas : " + casCelkem.ToString() + " Hodin");
            }
            
            
            sb.Append(File.ReadAllText("styles.txt"));

            System.IO.File.WriteAllText(save.FileName + ".html", sb.ToString());

            MessageBox.Show("Export dokončen");
        }

        private void buttonExportDetail_Click(object sender, EventArgs e)
        {
            {
                StringBuilder sb = new StringBuilder();
                SaveFileDialog save = new SaveFileDialog();

                
                if (save.ShowDialog() == DialogResult.Cancel)
                {
                    MessageBox.Show("Akce zrušena");
                    return;
                }
                sb.Append("<title>Detailní export</title>");
                sb.Append("<h1 style='color:black';>Detailní export</h1>");
                DateTime Actual = DateTime.Now;

                var firstDayOfMonth = new DateTime(Actual.Year, Actual.Month, 1);

                int index = comboBoxMonths.SelectedIndex;

                date = new DateTime(Actual.Year, 1, 1);
                for (int i = 1; i <= 12; i++)
                {
                    if (index == i)
                    {
                        date = date.AddMonths(index);
                        firstDayOfMonth = new DateTime(Actual.Year, date.Month, 1);
                    }
                }
                //}
                var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
                sb.Append("<h3>" + firstDayOfMonth + "-" + lastDayOfMonth + "</h3>");

                foreach (var z in Context.Zakaznici.ToList())
                {
                    sb.Append("<h1>" + z.Nazev + "</h1>");

                    TimeSpan casCelkem = new();
                    int cenaCelkem = 0;

                    foreach (var p in Context.Projekty.ToList().Where(x => x.IdZakaznik == z.Id))
                    {
                        CelkovaCenaProjektu = 0;
                        CelkemHodinProjektu = 0;
                        CelkemMinutProjektu = 0;
                        CelkemSekundProjektu = 0;

                        sb.Append("<h2>" + p.Nazev + "</h2>");
                        sb.Append("<table>");
                        sb.Append("<tr><th>Začátek</th><th>Konec</th><th>Činnost</th><th>Doba</th><th>Cena</th></tr>");

                        foreach (var c in Context.Cinnosti.ToList().Where(x => x.IdProjekt == p.Id))
                        {
                            if (c.Zacatek.Month == date.Month)
                            {

                                int CasZacatek = Convert.ToInt32(c.Zacatek.Hour) * 3600 + Convert.ToInt32(c.Zacatek.Minute) * 60 + Convert.ToInt32(c.Zacatek.Second);
                                int CasKonec = Convert.ToInt32(c.Konec.Hour) * 3600 + Convert.ToInt32(c.Konec.Minute) * 60 + Convert.ToInt32(c.Konec.Second);

                                int vysledek = CasZacatek - CasKonec;

                                int hodina = vysledek / 3600;

                                int PomocnaCena = vysledek / 3600;

                                hodina = (int)Math.Floor(Convert.ToDecimal(hodina));

                                int vyslednaHodina = Math.Abs((int)Math.Floor(Convert.ToDecimal(hodina)));

                                int minuta = (vysledek - (hodina * 3600)) / 60;
                                minuta = (int)Math.Floor(Convert.ToDecimal(minuta));

                                int vyslednaMinuta = Math.Abs((int)Math.Floor(Convert.ToDecimal(minuta)));
                                int sekunda = (vysledek - ((hodina * 3600) + (minuta * 60)));

                                sekunda = Math.Abs(sekunda);
                                int VyslednaCena = Math.Abs(PomocnaCena * Convert.ToInt32(p.HodinovaSazba));

                                sb.Append("<tr><td>" + c.Zacatek + "</td><td>" + c.Konec + "</td><td>" + c.PopisCinnosti + "</td><td>" + vyslednaHodina + ":" + vyslednaMinuta + ":" + sekunda + "</td><td>" + VyslednaCena + "Kč</td></tr>");

                                CelkovaCenaProjektu += VyslednaCena;
                                CelkemHodinProjektu += vyslednaHodina;
                                CelkemMinutProjektu += vyslednaMinuta;
                                CelkemSekundProjektu += sekunda;

                                if (CelkemMinutProjektu > 59)
                                {
                                    int CelkemHodinNavic = (int)Math.Floor(Convert.ToDecimal(CelkemMinutProjektu / 60));
                                    int CelkemZbyvajicichMinut = CelkemMinutProjektu - (CelkemHodinNavic * 60);
                                    CelkemHodinProjektu = +CelkemHodinNavic;
                                    CelkemMinutProjektu = CelkemZbyvajicichMinut;
                                }

                                if (CelkemSekundProjektu > 59)
                                {
                                    int CelkemMinutNavic = (int)Math.Floor(Convert.ToDecimal(CelkemSekundProjektu / 60));
                                    int CelkemZbyvajicichSekund = CelkemSekundProjektu - (CelkemMinutNavic * 60);
                                    CelkemMinutProjektu = +CelkemMinutNavic;
                                    CelkemSekundProjektu = CelkemZbyvajicichSekund;
                                }

                                casCelkem += (c.Konec - c.Zacatek);

                                cenaCelkem += VyslednaCena;

                            }
                        }
                        sb.Append("</table>");
                    }
                    sb.AppendLine("Celkem čas : " + casCelkem.ToString() );
                    sb.Append("Peníze:" + cenaCelkem.ToString()+"Kč");
                    
                    
                }


                sb.Append(File.ReadAllText("styles.txt"));

                System.IO.File.WriteAllText(save.FileName + ".html", sb.ToString());

                MessageBox.Show("Export dokončen");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == DataCinnost)
            {
                if (this.DataCinnost.Count == 0)
                {
                    return;
                }
                int index = this.dataGridView1.CurrentRow.Index;
                this.Context.Cinnosti.Remove(this.DataCinnost[index]);
                this.DataCinnost.RemoveAt(index);
                this.Context.SaveChanges();
            }
           
            if (dataGridView1.DataSource == DataZakaznik)
            {
                if (this.DataZakaznik.Count == 0)
                {
                    return;
                }
                int index = this.dataGridView1.CurrentRow.Index;
                this.Context.Zakaznici.Remove(this.DataZakaznik[index]);
                this.DataZakaznik.RemoveAt(index);
                this.Context.SaveChanges();
            }
        }
    }
}
