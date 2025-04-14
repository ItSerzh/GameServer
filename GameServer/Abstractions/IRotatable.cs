namespace GameServer.Abstractions;

public interface IRotatable
{
    double CurrentAngle { get; set; }

    double AdditionAngle { get; set; }
}

