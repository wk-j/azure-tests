using System;
using MyWeb.Controllers;
using Xunit;

namespace MyWeb.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var controller = new ValuesController();
            var values = controller.Get();
        }
    }
}
