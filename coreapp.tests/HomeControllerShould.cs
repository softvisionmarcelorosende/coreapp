using System;
using Xunit;
using coreapp.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace coreapp.tests
{
    public class HomeControllerShould
    {
        private readonly HomeController _sut;

        public HomeControllerShould()
        {
            _sut = new HomeController();
        }

        [Fact]
        public void ShowIndex()
        {
            var result = _sut.Index();
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void ShowPrivacy()
        {
            var result = _sut.Privacy();
            Assert.IsType<ViewResult>(result);
        }
    }
}
