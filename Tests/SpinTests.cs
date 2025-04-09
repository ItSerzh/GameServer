using GameServer.Implementations;
using GameServer;

namespace Tests;

public class SpinTests
{
    [Fact]
    public void CheckNewAngle()
    {
        // Arrange
        var ship = new Ship(null);
        ship.Angle = 15;
        var rotation = new Spin(ship);

        // Act
        rotation.Execute(25);

        // Assert
        Assert.Equal(40, ship.GetAngle());
    }

    [Fact]
    public void GetException_WhenNoStartAngle()
    {
        // Arrange
        var ship1 = new Ship(null);
        var rotation = new Spin(ship1);

        // Assert
        Assert.Throws<InvalidOperationException>(() => rotation.Execute(25)) ;
    }
}

