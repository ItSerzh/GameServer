using GameServer.Abstractions;
using GameServer.Model;

namespace GameServer.Implementations;

public class Ship(Vector vector) : IMovable, ISpinning
{
    private Vector _position = vector;
    private Vector _velocity;
    private double? _angle;

    public Vector Velocity { get => GetVelocity(); set => _velocity = value; }
    public Vector Position { get => GetPosition(); set => _position = value; }
    public double Angle { get => GetAngle(); set => _angle = value; }

    public Vector GetVelocity()
    {
        if (_velocity == null) throw new InvalidOperationException("Attempt to read not initialized value");
        return _velocity;
    }

    public Vector GetPosition()
    {
        if (_position == null) throw new InvalidOperationException("Attempt to read not initialized value");
        return _position;
    }


    public double GetAngle()
    {
        if (_angle == null) throw new InvalidOperationException("Attempt to get uninitialized angle");
        return _angle.Value;
    }
}

