using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;
using XamarinAppUIStyleTwo.ViewModels;

namespace XamarinAppUIStyleTwo.Others
{
    class ColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value == null)
            {
                return Color.Transparent;
            }
            var itemData = value as Agent;

            if(itemData.IsAssigned && itemData.IsTracking)
            {
                return Color.Green;
            }else if(itemData.IsAssigned && !(itemData.IsTracking))
            {
                return Color.Yellow;
            }else if (!itemData.IsAssigned)
            {
                return Color.Gray;
            }else
            {
                return Color.Gray;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
