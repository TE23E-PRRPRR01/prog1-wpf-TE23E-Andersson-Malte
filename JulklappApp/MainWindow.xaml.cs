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

namespace JulklappApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    //Våra variabler
    int maxJulklappar = 0;
    List<string> listaJulklappar = [];

    public MainWindow()
    {
        InitializeComponent();

        //Koppla list till listbox
        lsbJulklappar.ItemsSource = listaJulklappar;

        //Lås gränssnitt
        stpInmatning.IsEnabled = false;
        stpListan.IsEnabled = false;
    }

    private void KlickAnge(object sender, RoutedEventArgs e)
    {
        //Läs av rutan
        string antal = txbAntal.Text;

        //Första enkel kontroll
        if (antal == "")
        {
            txbStatus.Text = "Ange giltigt antal";
        }
        else
        {
            bool lyckas = int.TryParse(antal, out int talet);
            if (lyckas)
            {
                maxJulklappar = talet;
                txbStatus.Text = $"Max julklappar är {maxJulklappar}";

                //Lås gränssnitt
                stpMax.IsEnabled = false;
                stpInmatning.IsEnabled = true;
                stpListan.IsEnabled = true;
            }
            else
            {
                txbStatus.Text = "Ange giltigt antal";
            }
        }
    }

    private void KlickLäggTill(object sender, RoutedEventArgs e)
    {
        //Läs av textrutorna
        string julklapp = txbJulklapp.Text;
        string mottagare = txbMottagare.Text;

        if (julklapp == "")
        {
            txbStatus.Text = "Ange giltig julklapp";
        }
        else
        {
            if (mottagare == "")
            {
                txbStatus.Text = "Ange giltig mottagare";
            }
            else
            {
                listaJulklappar.Add($"{julklapp} till {mottagare}");
                lsbJulklappar.Items.Refresh();
            }
        }
    }

    private void KlickBytUt(object sender, RoutedEventArgs e)

    {

    }
}