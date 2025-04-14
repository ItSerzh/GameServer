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
        ship.CurrentAngle = 15;
        ship.AdditionAngle = 25;
        var rotation = new Rotate(ship);

        // Act
        rotation.Execute();

        // Assert
        Assert.Equal(40, ship.GetAngle());
    }

    [Fact]
    public void GetException_WhenNoStartAngle()
    {
        // Arrange
        var ship1 = new Ship(null);
        ship1.AdditionAngle = 8;
        var rotation = new Rotate(ship1);

        // Assert
        Assert.Throws<InvalidOperationException>(() => rotation.Execute()) ;
    }
}

