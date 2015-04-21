using System;
using NUnit.Framework;

namespace TodaysDate.Test
{
    [TestFixture]
    public class DateResolverTest
    {
        [Test]
        public void TodaysDateIsToday()
        {
            Assert.AreEqual(DateTime.Now.Date, DateResolver.TodaysDate().Date);
        }
    }
}
