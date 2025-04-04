namespace GameServer.Abstractions;

public interface ISpinning
{
    double GetAngle();
    void Spin(double angle);
}

