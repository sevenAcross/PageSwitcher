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

namespace PageSwitcher.Pages
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : UserControl, ISwitchable
    {
        public LoginPage ()
        {
            InitializeComponent ();
        }



        public void UtiliseState ( object state )
        {
            throw new NotImplementedException ();
        }

        private void buttonUser_Click ( object sender, RoutedEventArgs e )
        {
            Switcher.Switch ( new UserMainPage () );
        }

        private void buttonCleaner_Click ( object sender, RoutedEventArgs e )
        {

        }

        private void buttonService_Click ( object sender, RoutedEventArgs e )
        {
            ServiceMainPage page = new ServiceMainPage ();
            Switcher.Switch ( page );
            page.SetValue ( AttachedProperties.RoleProperty, Role.Service );

        }

        private void buttonAdvanced_Click ( object sender, RoutedEventArgs e )
        {

        }
    }
}
