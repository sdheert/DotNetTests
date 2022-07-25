using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace XUnitTest;

public class WebTest
{
    [Fact]
    public void HelloWorld()
    {
        using var application = new WebApplicationFactory<Program>();

        using var client = application.CreateClient();

        var result = client.GetAsync(string.Empty).Result.Content.ReadAsStringAsync().Result;

        Assert.Equal("Hello World!", result);
    }
}
