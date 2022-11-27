using System.Threading.Tasks;

namespace TeleCube.NET.API.Component.Interfaces
{
    internal interface IComponent
    {
        public Task LoadAsync();

        public Task UpdateAsync();
    }
}
