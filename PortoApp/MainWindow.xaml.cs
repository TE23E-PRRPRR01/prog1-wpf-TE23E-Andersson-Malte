using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PortoApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickBeräkna(object sender, RoutedEventArgs e)
    {
        //Variabler
        string Vikten = txbVikt.Text;
        int pris = 0;
        int frimärken = 0;

        //Kolla om heltal
        bool lyckas = int.TryParse(Vikten, out int vikt);
        if (lyckas)
        {
            //Beräkna om heltal
            if (vikt <= 50)
            {
                pris = 22;
                frimärken = 1;
            }
            else if (vikt > 50 && vikt <= 100)
            {
                pris = 44;
                frimärken = 2;
            }
            else if (vikt > 100 && vikt <= 250)
            {
                pris = 66;
                frimärken = 3;
            }
            else if (vikt > 250 && vikt <= 500)
            {
                pris = 88;
                frimärken = 4;
            }
            else if (vikt > 500 && vikt <= 1000)
            {
                pris = 132;
                frimärken = 6;
            }
            else if (vikt > 1000 && vikt <= 2000)
            {
                pris = 154;
                frimärken = 7;
            }

            if (vikt <= 2000)
            {
                //Skriv ut resultat
                lblResultat.Content = $"Brev som väger {vikt}g kostar {pris}kr ({frimärken} frimärken)";
            }
            else
            {
                lblResultat.Content = "För tungt!";
            }
        }
        else
        {
            //Felmeddelande om inte heltal
            lblResultat.Content = "Ange ett heltal!";
        }
    }
}