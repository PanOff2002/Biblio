using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Region
    {
        public static string Names (int number)
        {
            if (number==01||number==701||number==901)
            {
                return "Республика Адыгея";
            }
            if (number == 71 || number == 171 || number == 771||number==971)
            {
                return "Тульская область";
            }
            return "номер не найден в базе";
        }
    }
}
