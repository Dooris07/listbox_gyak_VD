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

namespace LB_gyak
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> lista = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
            lb_lista.ItemsSource = lista;
        }

        private void Hozzaad(object sender, RoutedEventArgs e)
        {
            if (tb_mezo.Text.Trim() != "")
            {
                string elem = tb_mezo.Text.Trim();
                lista.Add(elem);
                tb_mezo.Clear();
                Refresh();
            }
            else
            {
                MessageBox.Show("A semmit nem tudod megvenni kishaver. Kakukk.");
                tb_mezo.Clear();
            }
        }


        private void Enternyomo(object sender, KeyEventArgs e)
        {
            if (e.Key == (Key.Enter)) MessageBox.Show("almaaaaaaaa");
            
        }


        private void Torles(object sender, RoutedEventArgs e)
        {
            if (lb_lista.SelectedItem != null)
            {
                string valasztott = lb_lista.SelectedItem.ToString();
                lista.Remove(valasztott);
                Refresh();

            }
            else
            {
                MessageBox.Show("A semmit törölni sem tudom. Kakukk");
            }

        }

        private void Sztorno(object sender, RoutedEventArgs e)
        {
            lista.Clear();
            Refresh();
        }


        private void Refresh()
        {
            lb_lista.Items.Refresh();
            l_label.Content = $"A termékek száma: {lista.Count}";
        }

        private void Enternyomas(object sender, KeyEventArgs e)
        {
            if (e.Key == (Key.Enter))
            {
                Hozzaad(sender, e);
            }
        }
    }
}