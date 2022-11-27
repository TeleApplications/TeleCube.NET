using TeleCube.NET.API.DataStructures;

namespace TeleCube.NET.API.Component.Interfaces
{
    internal interface IMoveable
    {
        public Transform Transform { get; set; }
        public float Speed { get; set; }
    }
}
