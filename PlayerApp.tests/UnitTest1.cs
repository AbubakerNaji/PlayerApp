namespace PlayerApp.tests;

public class UnitTest1
{
    [Fact]
    public void UniqueIdTest()
    {
        foreach (var player in PlayerHandler.GetPlayers())
        {
            var count = PlayerHandler.GetPlayers().Count(p => p.Id == player.Id);
            Assert.True(count == 1);
        
        }

    }
    [Fact]
    public void SearchByIdTest()
    {
        var player = PlayerHandler.GetPlayer(1);
        Assert.True(player?.Id == 1);
    }
}
