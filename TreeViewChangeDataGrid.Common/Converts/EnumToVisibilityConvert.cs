using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using TreeViewChangeDataGrid.Common.Enums;

namespace TreeViewChangeDataGrid.Common.Converts
{
    public class EnumToVisibilityConvert : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Enum enumValue)
            {
                switch (enumValue)
                {
                    case NodeType.Grade:
                        return Visibility.Collapsed;
                    case NodeType.Student:
                        return Visibility.Visible;
                    default:
                        return Visibility.Collapsed;
                }
            }
            return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
