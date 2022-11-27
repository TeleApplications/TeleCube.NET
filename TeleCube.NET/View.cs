using System.Threading.Tasks;
using TeleCube.NET.API.Component.Interfaces;
using TeleCube.NET.API.DataStructures;

namespace TeleCube.NET.API
{
    internal abstract class View : IComponent
    {
        public Transform Transform { get; set; } =
            Transform.Zero;

        public async Task LoadAsync() 
        {
        }

        public async Task UpdateAsync()
        {
        }
    }
}
