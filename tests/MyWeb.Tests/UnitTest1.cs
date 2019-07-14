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
            var v1 = controller.Get();
            var v2 = controller.Get(10);
            controller.Post("1");
            controller.Put(1, "1");
            controller.Delete(1);
        }
    }
}
