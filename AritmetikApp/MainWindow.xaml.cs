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

namespace AritmetikApp;

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
        string operatorn = txbOperator.Text;
        string talet1 = txbTal1.Text;
        string talet2 = txbTal2.Text;

        bool lyckas = int.TryParse(talet1, out int tal1);
        if (lyckas)
        {
            bool lyckades = int.TryParse(talet2, out int tal2);
            if (lyckades)
            {
                if (operatorn == "+")
                {
                    lblResultat.Content = $"Resultat: {tal1 + tal2}";
                }
                else if (operatorn == "-")
                {
                    lblResultat.Content = $"Resultat: {tal1 - tal2}";
                }
                else if (operatorn == "*")
                {
                    lblResultat.Content = $"Resultat: {tal1 * tal2}";
                }
                else if (operatorn == "/")
                {
                    lblResultat.Content = $"Resultat: {tal1 / tal2}";
                }
                else
                {
                    lblResultat.Content = "Ange giltig operator!";
                }
            }
            else
            {
                lblResultat.Content = "Ange giltigt heltal!";
            }
        }
        else
        {
            lblResultat.Content = "Ange giltigt heltal!";
        }
    }
}