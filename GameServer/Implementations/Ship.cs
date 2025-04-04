using GameServer.Abstractions;
using GameServer.Model;

namespace GameServer.Implementations;

public class Ship(Vector vector) : IMovable, ISpinning
{
    private Vector _position = vector;
    private Vector _velocity;
    private double? _angle;

    public Vector GetPosition()
    {
        return _position;
    }

    public Vector Velocity { get => GetVelocity(); set => _velocity = value; }

    public Vector GetVelocity()
    {
        if (_velocity == null) throw new InvalidOperationException("Attempt to read not initialized value");
        return _velocity;
    }

    public void Move()
    {
        if (_position == null) throw new InvalidOperationException("Attempt to move object without position");
        _position += Velocity;
    }

    public double GetAngle()
    {
        if (_angle == null) throw new InvalidOperationException("Attempt to get uninitialized angle");
        return _angle.Value;
    }

    public void Spin(double angle)
    {
        if (_angle == null) throw new InvalidOperationException("Attempt to spin object without initial angle");
        _angle += angle;
    }

    public void SetAngle(double angle)
    {
        _angle = angle;
    }
}

