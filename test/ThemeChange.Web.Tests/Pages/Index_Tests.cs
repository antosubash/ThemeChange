﻿using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace ThemeChange.Pages
{
    public class Index_Tests : ThemeChangeWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
