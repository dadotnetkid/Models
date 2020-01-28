using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public static class StringExtensions
    {
        public static object ToObject(this object obj,string propertyName)
        {
            try
            {

                return obj.GetType().GetProperty(propertyName)?.GetValue(obj, null);
            }
            catch (Exception e)
            {
                return 0;
            }
        }
        public static int ToInt(this object obj)
        {
            try
            {
                return Convert.ToInt32(obj);
            }
            catch (Exception e)
            {
                return 0;
            }
        }
        public static decimal ToDecimal(this object obj)
        {
            try
            {
                return Convert.ToDecimal(obj);
            }
            catch (Exception e)
            {
                return 0;
            }
        }
    }
}
