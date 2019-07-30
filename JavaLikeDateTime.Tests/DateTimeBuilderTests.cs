using Cashwu.JavaLikeDateTime;
using FluentAssertions;
using System;
using Xunit;
using Xunit.Abstractions;

namespace JavaLikeDateTime.Tests
{
    public class DateTimeBuilderTests
    {
        private const int SpecificYear = 2019;
        private const int SpecificMonth = 7;
        private const int SpecificDay = 10;
        private readonly DateTimeBuilder _dateTimeBuilder;
        private readonly DateTime _specificDate = new DateTime(2020, 9, 1);
        private readonly ITestOutputHelper _testOutputHelper;

        public DateTimeBuilderTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
            _dateTimeBuilder = new DateTimeBuilder();
        }

        [Fact]
        public void build_datetime_init_value()
        {
            var actual = _dateTimeBuilder.Build();
            ResultShouldBe(actual, new DateTime());
        }

        [Fact]
        public void build_with_specific_year()
        {
            var actual = _dateTimeBuilder.AtYear(SpecificYear).Build();
            ResultShouldBe(actual, new DateTime(SpecificYear, 1, 1));
        }

        [Fact]
        public void build_with_specific_month()
        {
            var actual = _dateTimeBuilder.AtYear(SpecificYear).AtMonth(SpecificMonth).Build();
            ResultShouldBe(actual, new DateTime(SpecificYear, SpecificMonth, 1));
        }

        [Fact]
        public void build_with_specific_day()
        {
            var actual = _dateTimeBuilder.AtYear(SpecificYear).AtMonth(SpecificMonth).AtDay(SpecificDay).Build();
            ResultShouldBe(actual, new DateTime(SpecificYear, SpecificMonth, SpecificDay));
        }

        [Fact]
        public void init_builder_with_specific_date()
        {
            var actual = DateTimeBuilder.InitBuilder(_specificDate).Build();
            ResultShouldBe(actual, _specificDate);
        }

        [Fact]
        public void init_with_specific_date_and_change_month()
        {
            var actual = DateTimeBuilder.InitBuilder(_specificDate).AtMonth(SpecificMonth).Build();
            ResultShouldBe(actual, new DateTime(_specificDate.Year, SpecificMonth, _specificDate.Day));
        }

        private static void ResultShouldBe(DateTime actual, DateTime expected)
        {
            actual.Should().Be(expected);
        }
    }
}