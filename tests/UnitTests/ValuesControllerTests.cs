using System;
using Xunit;
using MyApp.Controllers;
using System.Linq;

namespace UnitTests
{
    public class ValuesControllerTests
    {
        private readonly  ValuesController controller;

        public ValuesControllerTests()
        {
            this.controller = new ValuesController();
        }

        [Fact]

        public void TestGet()
        {
            var values = this.controller.Get();
            Assert.True(values.Value.Count() == 2);
        }
    }
}
