using GameServer.Model;

namespace GameServer.Abstractions;

public interface IMovable
{
    Vector GetPosition();
    Vector GetVelocity();
    void Move();
}

