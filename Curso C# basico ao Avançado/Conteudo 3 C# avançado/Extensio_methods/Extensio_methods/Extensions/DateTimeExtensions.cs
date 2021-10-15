using System.Globalization;

namespace System // quando criar um extensio methodos para uma classe ou struct, ja coloca a classe no mesmo namespace do tipo que esta extendendo para não acrescentar import
{
    static class DateTimeExtensions
    {
        public static string ElapedTime(this DateTime thisObj)
        {
            TimeSpan duration = DateTime.Now.Subtract(thisObj);

            if(duration.TotalHours < 24.0)
            {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture)+ " Hours";
            }
            else
            {
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) +" Days";
            }
        
        }
    }
}
