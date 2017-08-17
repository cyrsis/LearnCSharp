using System;
using Xunit;

namespace Demo.Tests
{
    public class DiaryTests
    {
        [Fact]
        public void YesterdayOnNewYearsDay()
        {
            var sut = new Diary();

            var expected = new DateTime(2013, 12, 31).Date;

            #region
            DateTimeSubstitute.SubstituteDate = new DateTime(2014, 1, 1);
            #endregion

            var actual = sut.Yesterday.Date;

            Assert.Equal(expected, actual);
        }


    
    }
}
