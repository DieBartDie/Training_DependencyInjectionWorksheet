using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace DependencyInjection_Worksheet
{
    [TestFixture]
    public class PublicHolidayNotifierTests
    {
        [Test]
        public void IsYouthDayOnThe17June2013()
        {
            var dayGenerator = new DayGeneratorTest(new DateTime(2013,06,17));
            var sut = new PublicHolidayNotifier(dayGenerator);
            Assert.That(sut.GenerateNotification(), Is.EqualTo("Today is Youth Day"));
        }

        [Test]
        public void IsNormalDayOnThe18June2013()
        {
            var dayGenerator = new DayGeneratorTest(new DateTime(2013,06,18));
            var sut = new PublicHolidayNotifier(dayGenerator);
            Assert.That(sut.GenerateNotification(), Is.EqualTo("Today is a normal day"));            
        }        
    }

    public class DayGeneratorTest : IDayGenerator
    {
        private readonly DateTime _overrideDate;

        public DayGeneratorTest(DateTime overrideDate)
        {
            _overrideDate = overrideDate;
        }

        public DateTime Generate()
        {
            return _overrideDate;
        }
    }
}
