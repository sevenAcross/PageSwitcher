using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

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
            Switcher.Switch ( new Pages.LoginPage (), Role.Login );
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
            Switcher.Switch ( new Pages.LoginPage (), Role.Login );
        }

        private void buttonLanguage_Click ( object sender, RoutedEventArgs e )
        {

        }

        private void buttonAlarms_Click ( object sender, RoutedEventArgs e )
        {
            Switcher.Switch ( new Pages.AlarmPage (), Role.Alarm );
        }

        private void buttonInfo_Click ( object sender, RoutedEventArgs e )
        {
            Switcher.InfoButtonAction ();
        }
    }
}
