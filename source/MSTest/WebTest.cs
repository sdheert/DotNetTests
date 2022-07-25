using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTest;

[TestClass]
public class WebTest
{
    [TestMethod]
    public void HelloWorld()
    {
        using var application = new WebApplicationFactory<Program>();

        using var client = application.CreateClient();

        var result = client.GetAsync(string.Empty).Result.Content.ReadAsStringAsync().Result;

        Assert.AreEqual("Hello World!", result);
    }
}
