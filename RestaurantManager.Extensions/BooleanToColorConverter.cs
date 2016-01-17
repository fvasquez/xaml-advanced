using System;
using Windows.UI;
using Windows.UI.Xaml.Data;

namespace RestaurantManager.Extensions
{
    public sealed class BooleanToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            Color returnValue = Colors.Transparent;

            if (value is bool)
            {
                returnValue = (bool)value ? Colors.Red : Colors.Transparent;
            }

            return returnValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            bool returnValue = default(bool);

            if (value is Color)
            {
                if ((Color)value == Colors.Transparent) { returnValue = false; }
                else if ((Color)value == Colors.Red) { returnValue = true; }
            }

            return returnValue;
        }
    }
}
