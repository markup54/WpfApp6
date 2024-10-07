using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Obraz> WszystkieObrazy { get; set; }
        public int licznikObrazow = 0;

        public MainWindow()
        {
            InitializeComponent();
            WszystkieObrazy = new List<Obraz>();
            WszystkieObrazy.Add(new Obraz("zielony las", "las1.jpg"));
            WszystkieObrazy.Add(new Obraz("zielony las", "las2.jpg"));
            WszystkieObrazy.Add(new Obraz("zielony las", "las3.jpg"));
            WszystkieObrazy.Add(new Obraz("ośnieżone góry", "mont.jpg"));
            wyswietlObraz(0);
        }

        private void wyswietlObraz(int i)
        {
            WszystkieObrazy[i].LiczbaWyswietlen++;
            liczbaWyswietlenTextBlock.Text = WszystkieObrazy[i].LiczbaWyswietlen.ToString();
            obrazImage.Source = WszystkieObrazy[i].obrazZrodlo;
            opisObrazkaTextBox.Text = WszystkieObrazy[i].Opis;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            licznikObrazow++;
            if (licznikObrazow == WszystkieObrazy.Count)
                licznikObrazow = 0;
            wyswietlObraz(licznikObrazow);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            licznikObrazow--;
            if (licznikObrazow < 0)
                licznikObrazow = WszystkieObrazy.Count - 1;
            wyswietlObraz(licznikObrazow);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            WszystkieObrazy[licznikObrazow].Opis = opisObrazkaTextBox.Text;
        }
    }
}
