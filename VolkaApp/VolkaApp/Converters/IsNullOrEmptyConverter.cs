using System;
using System.Collections.Generic;
using System.Linq;
using Windows.UI.Xaml.Data;

namespace VolkaApp.Converters
{
    public class IsNullOrEmptyConverter : IValueConverter
    {
        public object EmptyValue { get; set; }
        public object NonEmptyValue { get; set; }

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value == null)
                return EmptyValue;
            var enumerable = value as IEnumerable<object>;
            if (enumerable != null && enumerable.Count() == 0)
                return EmptyValue;
            if (value is string && string.IsNullOrEmpty(value as string))
                return EmptyValue;
            return NonEmptyValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
