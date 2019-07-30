using System;

namespace Cashwu.JavaLikeDateTime
{
    public class DateTimeBuilder
    {
        private readonly DateTime _defaultDateTime;
        private int? _month;
        private int? _year;

        public DateTimeBuilder()
        {
            _defaultDateTime = new DateTime();
        }

        public DateTimeBuilder AtMonth(int month)
        {
            _month = month;
            return this;
        }

        public DateTimeBuilder AtYear(int year)
        {
            _year = year;
            return this;
        }

        public DateTime Build()
        {
            return new DateTime(_year ?? _defaultDateTime.Year, _month ?? _defaultDateTime.Month, _defaultDateTime.Day);
        }
    }
}