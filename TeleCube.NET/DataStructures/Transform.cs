using System.Numerics;

namespace TeleCube.NET.API.DataStructures
{
    internal struct Transform
    {
        public Vector3 Position { get; set; }
        public Quaternion Rotation { get; set; }
        public float Scale { get; set; }

        public static Transform Zero { get; } =
            new(Vector3.Zero, Quaternion.Identity, 0);


        public Transform(Vector3 position, Quaternion rotation, float scale = 1f) 
        {
            Position = position;
            Rotation = rotation;
            Scale = scale;
        }
    }
}
