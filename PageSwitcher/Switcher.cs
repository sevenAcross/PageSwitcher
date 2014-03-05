using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace PageSwitcher
{
    public static class Switcher
    {
        private static bool infoButton = true;
        private static UserControl lastPage = null;

        public static MainWindow mainWindow;

        public static void Switch ( UserControl newPage, Role role )
        {
            mainWindow.pageHolder.SetValue ( AttachedProperties.RoleProperty, role );

            Uri uri;
            if ( role == Role.Login )
            {
                uri = new Uri ( @"/Icons/info.png", UriKind.RelativeOrAbsolute );
                infoButton = true;
            }
            else
            {
                uri = new Uri ( @"/Icons/back_to_main_screen.png", UriKind.RelativeOrAbsolute );
                infoButton = false;
            }
            var bitmap = new BitmapImage ( uri );
            mainWindow.buttonInfo.SetValue ( AttachedProperties.IconProperty, bitmap );

            lastPage = (UserControl) mainWindow.pageHolder.Child;

            mainWindow.Navigate ( newPage );
        }

        public static void Switch ( UserControl newPage, object state )
        {
            mainWindow.Navigate ( newPage, state );
        }

        public static void InfoButtonAction ()
        {
            if ( infoButton == false )
            {
                Switch ( lastPage, Role.Login );
                lastPage = null;
            }
        }
    }
}
