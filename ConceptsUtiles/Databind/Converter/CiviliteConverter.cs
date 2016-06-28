using ApplicationDeBase.ViewModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ApplicationDeBase.Converter
{
    class CiviliteConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, 
            CultureInfo culture)
        {
            if (value is CiviliteEnum)
            {
                if ((CiviliteEnum)value == CiviliteEnum.Monsieur)
                {
                    return "M.";
                }
                else
                {
                    return "Mme";
                }
            }
            else
            {
                return "N/D";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, 
            CultureInfo culture)
        {
            //Pas besoin d'un converteur inverse
            return null;
        }
    }
}
