using NUnit.Framework;


namespace TestForTeamCity.Tests
{
    public class ProgramTests
    {
        [Test]
        public void PrintSomeText_WithText()
        {
            var p = new Program();
            var result = p.PrintSomeText("per");
            Assert.AreEqual(result,1);
        }
    }
}
