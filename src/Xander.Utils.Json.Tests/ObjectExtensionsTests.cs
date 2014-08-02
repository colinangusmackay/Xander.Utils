using NUnit.Framework;

namespace Xander.Utils.Json.Tests
{
    [TestFixture]
    public class ObjectExtensionsTests
    {
         [Test]
         public void AsJson_StringInput_QuotedStringOutput()
         {
             string input = "It's a string of text";

             var result = ObjectExtensions.AsJson(input);

             string expected = "\"" + input + "\"";
             Assert.AreEqual(expected, result);
         }
    }
}