using System;

namespace Cashwu.JavaLikeDateTime
{
    public class DateTimeBuilder
    {
        private readonly DateTime _defaultDateTime;
        private int? _day;
        private int? _month;
        private int? _year;

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

        public DateTimeBuilder AtDay(int day)
        {
            _day = day;
            return this;
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
            return new DateTime(_year ?? _defaultDateTime.Year, _month ?? _defaultDateTime.Month,
                                _day ?? _defaultDateTime.Day);
        }
    }
}