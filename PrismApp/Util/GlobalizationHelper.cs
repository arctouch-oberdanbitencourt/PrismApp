using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Windows.Globalization.DateTimeFormatting;
using Windows.Globalization.NumberFormatting;

namespace PrismApp.Util
{
    internal class DateTimeFormat
    {
        public static string ToShortDateTimeFormat(DateTime datetime, string timezone = null)
        {
            return string.Format("{0} {1}", ToShortDateFormat(datetime, timezone), ToShortTimeFormat(datetime, timezone));
        }

        public static string ToLongtDateTimeFormat(DateTime datetime, string timezone = null)
        {
            return string.Format("{0} {1}", ToLongDateFormat(datetime, timezone), ToLongTimeFormat(datetime, timezone));
        }

        public static string ToShortDateFormat(DateTime datetime, string timezone = null)
        {
            return String.IsNullOrEmpty(timezone)
                ? DateTimeFormatter.ShortDate.Format(datetime)
                : DateTimeFormatter.ShortDate.Format(datetime, timezone);
        }

        public static string ToShortTimeFormat(DateTime datetime, string timezone = null)
        {
            return String.IsNullOrEmpty(timezone)
                ? DateTimeFormatter.ShortTime.Format(datetime)
                : DateTimeFormatter.ShortTime.Format(datetime, timezone);
        }

        public static string ToLongDateFormat(DateTime datetime, string timezone = null)
        {
            return String.IsNullOrEmpty(timezone)
                ? DateTimeFormatter.LongDate.Format(datetime)
                : DateTimeFormatter.LongDate.Format(datetime, timezone);
        }

        public static string ToLongTimeFormat(DateTime datetime, string timezone = null)
        {
            return String.IsNullOrEmpty(timezone)
                ? DateTimeFormatter.LongTime.Format(datetime)
                : DateTimeFormatter.LongTime.Format(datetime, timezone);
        }
    }

    internal class Currency
    {
        private static readonly string USD = "USD";

        public static string ToUSD(double fractionalNumber)
        {
            return Format(USD, fractionalNumber);
        }

        public static string Format(string currencyCode, double fractionalNumber)
        {
            return (new CurrencyFormatter(currencyCode)).Format(fractionalNumber);
        }
    }
}