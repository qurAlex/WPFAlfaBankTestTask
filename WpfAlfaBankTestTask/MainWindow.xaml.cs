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

namespace WpfAlfaBankTestTask
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void ButtonMinimize_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ButtonSysXml_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonRegex_Click(object sender, RoutedEventArgs e)
        {

        } 
        
        private void ButtonExcel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonWord_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonTxt_Click(object sender, RoutedEventArgs e)
        {

        }
    }
   

    
}
