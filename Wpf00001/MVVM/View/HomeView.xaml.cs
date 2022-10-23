using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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

namespace Wpf00001.MVVM.View
{
    /// <summary>
    /// Logika interakcji dla klasy HomeView.xaml
    /// </summary>
    public partial class HomeView : UserControl
    {
        public HomeView()
        {
            InitializeComponent();
        }

        private void Border_Click(object sender, RoutedEventArgs e)
        {
            /*
            var br = sender as Border;
            Console.WriteLine(br.Child);
            SystemSounds.Beep.Play();
            var gr = br.Child as Grid;
            Console.WriteLine(gr.Children[0]);
            var sp = gr.Children[0] as StackPanel;
            Console.WriteLine(sp.Children[0]);
            var tb=sp.Children[0] as TextBlock;
            tb.Foreground=Brushes.Red;
            */
        }
    }
}
