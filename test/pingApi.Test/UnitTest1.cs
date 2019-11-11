using System;
using Xunit;
using pingApi.contollers;

namespace pingApi.Test
{
    public class UnitTest1
    {
        PingController myContorller = new PingController();

        [Fact]
        public void GetReturnsPong()
        {
            var returnValue = myContorller.Ping();
            Assert.Equal("ping",returnValue.ToString());
        }
    }
}
