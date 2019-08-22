using System;
using Xunit;
using SampleAPI.Controllers;

namespace SampleAPI.Test
{
    public class UnitTest1
    {
        ValuesController controller = new ValuesController();
        [Fact]
        public void GetReturnsNames()
        {
            var returnValue = controller.Get(1);
            Assert.Equal("Chloe McDermott - Test API", returnValue.Value);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
