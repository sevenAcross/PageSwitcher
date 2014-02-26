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

namespace PageSwitcher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow ()
        {
            InitializeComponent ();
            Switcher.mainWindow = this;
            Switcher.Switch ( new Pages.LoginPage () );
        }

        internal void Navigate ( UserControl newPage )
        {
            pageHolder.Child = newPage;
        }

        internal void Navigate ( UserControl newPage, object state )
        {
            pageHolder.Child = newPage;

            ISwitchable s = newPage as ISwitchable;
            if ( s != null )
                s.UtiliseState ( state );
            else
                throw new ArgumentException ( "New page " + newPage.Name.ToString () + "is not ISwitchable" );
        }

        private void buttonLogin_Click ( object sender, RoutedEventArgs e )
        {
            Switcher.Switch ( new Pages.LoginPage () );
        }

        private void buttonLanguage_Click ( object sender, RoutedEventArgs e )
        {

        }

        private void buttonAlarms_Click ( object sender, RoutedEventArgs e )
        {

        }

        private void buttonInfo_Click ( object sender, RoutedEventArgs e )
        {

        }
    }
}
