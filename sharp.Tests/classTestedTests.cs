using calculette.calculator;

namespace calculetteSharp.Tests;

public class classTestedTests
{
    private readonly ClassTested _pingTest;
    public classTestedTests()
    {
        _pingTest = new ClassTested();

    }
    [Fact]
    public void ClassTested_SendingPing_ReturnString()
    {
        // before => var pingTest = new ClassTested();

        // after =>
        var res = _pingTest.SendPing();

        // res.Should().Be("Success: Ping"); avec fluentAssertions
        res.Equals("Succes: Ping");
    }
}
