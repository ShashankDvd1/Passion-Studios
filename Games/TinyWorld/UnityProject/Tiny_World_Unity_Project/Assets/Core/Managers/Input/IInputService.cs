using UnityEngine;
using WonderForge.TinyWorld.Core.Runtime.Interfaces;

namespace WonderForge.TinyWorld.Core.Managers.Input
{
    public interface IInputService : IGameService
    {
        Vector2 GetMovementVector();
        bool IsActionPressed();
    }
}
