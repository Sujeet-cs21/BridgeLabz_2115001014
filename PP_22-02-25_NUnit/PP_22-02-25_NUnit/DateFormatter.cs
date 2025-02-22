using System.Globalization;
using System;

namespace PP_22_02_25_NUnit
{
    public class DateFormatter
    {
        public string FormatDate(string inputDate)
        {
            if (string.IsNullOrEmpty(inputDate))
                throw new ArgumentException("Input date cannot be null or empty.");

            DateTime parsedDate;
            if (!DateTime.TryParseExact(inputDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate))
            {
                throw new FormatException("Invalid date format. Expected format is yyyy-MM-dd.");
            }

            return parsedDate.ToString("dd-MM-yyyy");
        }
    }
}
