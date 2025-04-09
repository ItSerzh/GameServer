using GameServer.Abstractions;

namespace GameServer;

public class Move(IMovable movable)
{
    public void Execute()
    {
        movable.Position += movable.Velocity;
    }
}
