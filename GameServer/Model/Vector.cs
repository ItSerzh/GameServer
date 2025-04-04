using System.Numerics;

namespace GameServer.Model;

public class Vector
{
    public int? X { get; set; }

    public int? Y { get; set; }

    public static Vector operator +(Vector v1, Vector v2)
        => new() { X = v1.X + v2.X, Y = v1.Y + v2.Y };
}

