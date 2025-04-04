using GameServer.Abstractions;

namespace GameServer;

public class Spin(ISpinning spinning)
{
    public void Rotate(double angle)
    {
        spinning.Spin(angle);
    }
}

