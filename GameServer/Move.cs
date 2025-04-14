using GameServer.Abstractions;

namespace GameServer;

public class Move(IMovable movable) : ICommand
{
    public void Execute()
    {
        movable.Position += movable.Velocity;
    }
}
