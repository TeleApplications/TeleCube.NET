using Microsoft.Xna.Framework.Graphics;
using System.Collections.Immutable;
using System.Threading.Tasks;
using TeleCube.NET.API.Component.Interfaces;
using TeleCube.NET.API.DataStructures;

namespace TeleCube.NET.API.Component
{
    internal abstract class GameObject : IComponent
    {
        protected virtual ImmutableArray<IObjectComponent> Components { get; }

        public abstract Model ObjectModel { get; }
        public Transform Transform { get; set; } =
            Transform.Zero;

        public virtual Task LoadAsync() { return Task.CompletedTask; }
        public virtual Task UpdateAsync() { return Task.CompletedTask; }
    }
}
