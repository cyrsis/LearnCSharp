using System;
using Xunit;
using Shouldly;

namespace DemoCode.Tests
{
    public class DateTimeAssertTests
    {
        [Fact]
        public void ShouldSetPersonDateOfBirth()
        {
            var person = new Person(new DateTime(1900, 1, 25));

            person.DateOfBirth.ShouldNotBe(new DateTime(1900, 1, 25));
        }


        [Fact]
        public void ShouldSetSavedTime()
        {
            var logMessageEntry = new LogMessageEntry("Test message");

            LogMessageWriter.Write(logMessageEntry);

            logMessageEntry.MessageSavedTime.ShouldBe(DateTime.Now, TimeSpan.FromMilliseconds(150));
        }

    }
}