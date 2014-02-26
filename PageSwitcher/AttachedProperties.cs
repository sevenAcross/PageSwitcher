using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace PageSwitcher
{
    public enum Role
    {
        User,
        Cleaner,
        Service,
        Advanced,
        Alarm,
        WarningOrange,
        WarningYellow
    };

    public class AttachedProperties
    {

        #region Icon Attached Dependency Property
        public static readonly DependencyProperty IconProperty;

        public static ImageSource GetIcon ( DependencyObject obj )
        {
            return (ImageSource) obj.GetValue ( IconProperty );
        }

        public static void SetIcon ( DependencyObject obj, ImageSource source )
        {
            obj.SetValue ( IconProperty, source );
        }

        #endregion

        #region Role Attached Dependency Property

        public static readonly DependencyProperty RoleProperty;

        public static Role GetRole ( DependencyObject obj )
        {
            return (Role) obj.GetValue ( RoleProperty );
        }

        public static void SetRole ( DependencyObject obj, Role value )
        {
            obj.SetValue ( RoleProperty, value );
        }

        #endregion

        #region RoundedRight Attached Dependency Property

        public static readonly DependencyProperty RoundedRightProperty;

        public static bool GetRoundedRight ( DependencyObject obj )
        {
            return (bool) obj.GetValue ( RoundedRightProperty );
        }

        public static void SetRoundedRight ( DependencyObject obj, bool value )
        {
            obj.SetValue ( RoundedRightProperty, value );
        }

        #endregion

        static AttachedProperties ()
        {
            // Register the attached dependency properties
            var metadata = new FrameworkPropertyMetadata ( (ImageSource) null );
            IconProperty = DependencyProperty.RegisterAttached (
                "Icon",
                typeof ( ImageSource ),
                typeof ( AttachedProperties ),
                metadata
                );

            metadata = new FrameworkPropertyMetadata ( (String) null );
            RoleProperty = DependencyProperty.RegisterAttached (
                "Role",
                typeof ( Role ),
                typeof ( AttachedProperties ),
                new PropertyMetadata ( default ( Role ) )
                );

            RoundedRightProperty = DependencyProperty.RegisterAttached (
                "RoundedRight",
                typeof ( bool ),
                typeof ( AttachedProperties ),
                new PropertyMetadata ( default ( bool ) )
                );
        }
    }
}
