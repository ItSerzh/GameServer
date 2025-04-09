using GameServer.Abstractions;

namespace GameServer;

public class Spin(ISpinning spinning)
{
    public void Execute(double angle)
    {
        spinning.Angle += angle;
    }
}

