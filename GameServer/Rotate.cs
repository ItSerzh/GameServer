using GameServer.Abstractions;

namespace GameServer;

public class Rotate(IRotatable rotatable) : ICommand
{
    public void Execute()
    {
        rotatable.CurrentAngle += rotatable.AdditionAngle;
    }
}

