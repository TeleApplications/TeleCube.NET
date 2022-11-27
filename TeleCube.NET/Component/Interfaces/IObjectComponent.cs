using System.Threading.Tasks;

namespace TeleCube.NET.API.Component.Interfaces
{
    internal interface IObjectComponent : IComponent
    {
        public GameObject GameObject { get; set; }

        public Task LoadAsync();

        public Task UpdateAsync();
    }
}
