using GameServer;
using GameServer.Implementations;
using GameServer.Model;

namespace Tests;

public class MovableTests
{
    [Fact]
    public void CheckDesctionationAfterMove()
    {
        // Arrange
        var startPosition = new Vector { X = 12, Y = 5 };
        var velocity = new Vector { X = -7, Y = 3 };
        var ship1 = new Ship(startPosition)
        {
            Velocity = velocity
        };

        // Act
        var movementShip1 = new Move(ship1);
        movementShip1.Execute();

        // Assert
        Assert.Equal(5, ship1.GetPosition().X);
        Assert.Equal(8, ship1.GetPosition().Y);
    }

    [Fact]
    public void GetException_IfCantReadVelocity()
    {
        // Arrange
        var startPosition = new Vector { X = 12, Y = 5 };
        var ship1 = new Ship(startPosition);
        // Assert
        Assert.Throws<InvalidOperationException>(() => ship1.Velocity);
    }

    [Fact]
    public void GetException_WhenNoInitialPosition()
    {
        // Arrange
        var velocity = new Vector { X = -7, Y = 3 };
        Vector? startPosition = null;
        var ship1 = new Ship(startPosition) { Velocity = velocity };
        // Assert
        Assert.Throws<InvalidOperationException>(ship1.Move);
    }
}