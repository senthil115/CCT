using NuGet.Frameworks;

namespace TemplateEngine.Tests;

public class TemplateEngineTests
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase("John")]
    [TestCase("David")]
    public void ShouldWorkForOneVariable(string value)
    {
        TemplateEngine templateEngine = new();
        templateEngine.SetTemplate("Hello {name}");
        templateEngine.SetVariable("name", value);

        String result = templateEngine.Evaluate();

        Assert.That("Hello " + value, Is.EqualTo(result));
    }

    [TestCase("John", "Doe")]
    [TestCase("David", "Mike")]
    public void ShouldWorkForTwoVariables(string firstValue, string secondValue)
    {
        TemplateEngine templateEngine = new();
        templateEngine.SetTemplate("Hello, {firstName} {lastName}");
        templateEngine.SetVariable("firstName", firstValue);
        templateEngine.SetVariable("lastName", secondValue);

        String result = templateEngine.Evaluate();

        Assert.That("Hello, " + firstValue + " " + secondValue, Is.EqualTo(result));
    }
}