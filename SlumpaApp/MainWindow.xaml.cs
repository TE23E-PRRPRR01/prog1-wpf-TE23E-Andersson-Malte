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

namespace SlumpaApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickSlumpa(object sender, RoutedEventArgs e)
    {
        //Kolla om värdet är giltigt
        if (int.TryParse(Maxvärde.Text, out int maxvärdet))
        {
            //Giltigt, då använd användarens maxvärde
            maxvärdet = int.Parse(Maxvärde.Text);
            Felmeddelande.Text = "";
        }
        else
        {
            //Inte giltigt, sätt maxvärde till 100 och skicka felmeddelande
            maxvärdet = 100;
            Felmeddelande.Text = "Ogiltigt heltal. Maxvärdet sattes till 100";
        }
        
        //int maxvärdet = int.Parse(Maxvärde.Text);

        //Slumpa tal
        int slumptal = Random.Shared.Next(1, maxvärdet+1);

        //Skriva ut
        Slumptalet.Text = slumptal.ToString();
    }
}