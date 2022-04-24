using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._04._22
{
    internal class Date
    {
        private DateTime data;
        public Date(int day, int month, int year)
        {
            data = new DateTime(year, month, day);
        }
        public Date()
        {
            data = new DateTime(2010, 1, 1);
        }
        public string dayBefore()
        {
            return data.AddDays(-1).ToString("dddd");
        }
        public string NextDay()
        {
            return data.AddDays(1).ToString("dddd");
        }
        public int daysLeft()
        {
            return DateTime.DaysInMonth(data.Year, data.Month) - data.Day;
        }
        public int Day
        {
            get { return data.Day; }
            set { data = new DateTime(data.Year, data.Month, value); }
        }
        public int Month
        {
            get { return data.Month; }
            set { data = new DateTime(data.Year, value, data.Day); }
        }
        public int Year
        {
            get { return data.Year; }
            set { data = new DateTime(value, data.Month, data.Day); }
        }
        public bool IsLeapYear
        {
            get { return DateTime.IsLeapYear(data.Year); }
        }
        public DateTime this[int i]
        {
            get { return data.AddDays(i); }
        }
        public bool IsStartOfYear
        {
            get { return data.Day == 1 && data.Month == 1; }
        }
        public static bool operator ==(Date d1, Date d2)
        {
            return d1.data == d2.data;
        }
        public static bool operator !=(Date d1, Date d2)
        {
            return d1.data != d2.data;
        }

    }
}
