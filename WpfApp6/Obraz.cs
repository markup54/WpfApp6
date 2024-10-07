using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace WpfApp6
{
    public class Obraz
    {
        public int LiczbaWyswietlen { get; set; }
        public String Opis { get; set; }
        public BitmapImage obrazZrodlo { get; set; }

        public Obraz(string opis, string plik)
        {
            LiczbaWyswietlen = 0;
            Opis = opis;
            obrazZrodlo = new BitmapImage(new Uri(plik,UriKind.Relative));
        }
    }
}
