using GameServer.Model;

namespace GameServer.Abstractions;

public interface IMovable
{
    Vector Position { get; set; }
    Vector Velocity { get; set; }
}

