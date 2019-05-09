using System;
using Xunit;
using coreapp.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace coreapp.tests
{
    public class HomeControllerShould
    {
        [Fact]
        public void ShowIndex()
        {
            var homeController = new HomeController();
            var result = homeController.Index();

            Assert.IsType<ViewResult>(result);
        }
    }
}
