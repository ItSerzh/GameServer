using GameServer.Implementations;
using GameServer;

namespace Tests;

public class SpinTests
{
    [Fact]
    public void CheckNewAngle()
    {
        // Arrange
        var ship1 = new Ship(null);
        ship1.SetAngle(15);
        var rotation = new Spin(ship1);

        // Act
        rotation.Rotate(25);

        // Assert
        Assert.Equal(40, ship1.GetAngle());
    }

    [Fact]
    public void GetException_WhenNoStartAngle()
    {
        // Arrange
        var ship1 = new Ship(null);
        var rotation = new Spin(ship1);

        // Assert
        Assert.Throws<InvalidOperationException>(() => rotation.Rotate(25)) ;
    }
}

