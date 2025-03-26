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
using System.Net.Http;
using System.Net.Http.Json;

namespace AiChatApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    //Redskap fär att kommunicera över HTTP
    HttpClient klient = new HttpClient();
    string url = "http://10.151.169.5:11434";

    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickSkicka(object sender, RoutedEventArgs e)
    {
        //läsa av den där
        string prompt = txbPrompt.Text;

        //Skapa ett Json objekt
        object data = new
        {
            model = "phi4:latest",
            prompt = prompt,
            max_tokens = 50
        };

        //Skicka till oollama ai-servern
        SkickaTillOllama(data);
    }

    private void SkickaTillOllama(object data)
    {
        try
        {
            //Skicka data till srevern
            HttpResponseMessage svar = klient.PostAsJsonAsync(url, data).Result;

            //kontrollera nåt
            svar.EnsureSuccessStatusCode();

            //läs av det som kommer
            string råtext = svar.Content.ReadAsStringAsync().Result;

            //skriv ut
            txbSvar.Text = råtext;

            //dela upp råtext
            string[] rader = råtext.Split("\n");

            //gå ingeom
            foreach (string rad in rader)
            {
                //finns i sjön
                if (rad.Contains("response"))
                {
                  txbSvar.Text += PlockaUtToken(rad);
                }
            }
        }
        catch (HttpRequestException e)
        {
            txbSvar.Text = $"Fel: {e.Message}";
        } 
    }

    private string PlockaUtToken(string rad)
    {
        int start = rad.IndexOf("response") + 11;
        int slut = rad.IndexOf("\"", start);

        //plocka brär i token
        return rad.Substring(start, slut -start);
    }
}