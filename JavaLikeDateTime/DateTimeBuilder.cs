using System;

namespace Cashwu.JavaLikeDateTime
{
    public class DateTimeBuilder
    {
        private DateTime _defaultDateTime;

        private DateTimeBuilder(DateTime defaultDateTime)
        {
            _defaultDateTime = defaultDateTime;
        }

        public DateTimeBuilder()
        {
            _defaultDateTime = new DateTime();
        }

        public static DateTimeBuilder InitBuilder(DateTime defaultDate)
        {
            return new DateTimeBuilder(defaultDate);
        }

        public DateTimeBuilder After(TimeSpan timeSpan)
        {
            _defaultDateTime = _defaultDateTime.Add(timeSpan);
            return this;
        }

        public DateTimeBuilder AtDay(int day)
        {
            _defaultDateTime = new DateTime(_defaultDateTime.Year, _defaultDateTime.Month, day);
            return this;
        }

        public DateTimeBuilder AtEndOfMonth()
        {
            var endDayOfMonth = DateTime.DaysInMonth(_defaultDateTime.Year, _defaultDateTime.Month);
            _defaultDateTime = new DateTime(_defaultDateTime.Year, _defaultDateTime.Month, endDayOfMonth);
            return this;
        }

        public DateTimeBuilder AtMonth(int month)
        {
            _defaultDateTime = new DateTime(_defaultDateTime.Year, month, _defaultDateTime.Day);
            return this;
        }

        public DateTimeBuilder AtYear(int year)
        {
            _defaultDateTime = new DateTime(year, _defaultDateTime.Month, _defaultDateTime.Day);
            return this;
        }

        public DateTime Build()
        {
            return _defaultDateTime;
        }
    }
}