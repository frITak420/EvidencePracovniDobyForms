using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Cinnost
    {
        public int Id { get; set; }
        public string PopisCinnosti { get; set; }
        public DateTime Zacatek { get; set; }
        public DateTime Konec { get; set; }
        public int IdProjekt { get; set; }
        public int IdUzivatel { get; set; }

    }
}
