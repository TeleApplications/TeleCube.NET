using System;
using TeleCube.NET.API.Component.Interfaces;

namespace TeleCube.NET.API.Component
{
    internal sealed class ComponentManager
    {
        private int currentIndex = 0;

        public ReadOnlyMemory<IComponent> Components { get; private set; }

        public ComponentManager() 
        {
        }
    }
}
