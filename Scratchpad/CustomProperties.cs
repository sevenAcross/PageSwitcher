using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Scratchpad
{
    public class CustomProperties
    {
        public static readonly DependencyProperty RoleProperty;

        public static String GetRole ( DependencyObject obj )
        {
            return (String) obj.GetValue ( RoleProperty );
        }

        public static void SetRole ( DependencyObject obj, String value )
        {
            obj.SetValue ( RoleProperty, value );
        }

        static CustomProperties ()
        {
            var metadata = new FrameworkPropertyMetadata (
                null,
                FrameworkPropertyMetadataOptions.AffectsRender
                );
            metadata.Inherits = true;
            RoleProperty = DependencyProperty.RegisterAttached (
            "Role",
            typeof ( String ),
            typeof ( CustomProperties ),
            metadata
            );
        }
    }
}
