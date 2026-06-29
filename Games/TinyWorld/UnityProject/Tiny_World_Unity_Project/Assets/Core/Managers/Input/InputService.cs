using System.Threading.Tasks;
using UnityEngine;
using WonderForge.TinyWorld.Core.Runtime.Interfaces;
using WonderForge.TinyWorld.Core.Utilities;

namespace WonderForge.TinyWorld.Core.Managers.Input
{
    public class InputService : IInputService, IInitializable, IUpdatable
    {
        private const string LOG_PREFIX = "[Input]";

        public Task InitializeAsync()
        {
            GameLogger.Log($"{LOG_PREFIX} Input Service Initialized.");
            // Future: Initialize Unity's New Input System actions here.
            return Task.CompletedTask;
        }

        public void Tick(float deltaTime)
        {
            // Input logic processing per frame can go here if needed.
        }

        public Vector2 GetMovementVector()
        {
            return Vector2.zero; // Stub for MVP
        }

        public bool IsActionPressed()
        {
            return false; // Stub for MVP
        }
    }
}
