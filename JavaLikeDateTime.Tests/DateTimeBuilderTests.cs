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
        private readonly DateTimeBuilder _dateTimeBuilder;
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
        public void build_with_specific_month ()
        {
            var actual = _dateTimeBuilder.AtYear(SpecificYear).AtMonth(7).Build();
            ResultShouldBe(actual, new DateTime(SpecificYear, 7, 1));
        }


        private static void ResultShouldBe(DateTime actual, DateTime expected)
        {
            actual.Should().Be(expected);
        }
    }
}