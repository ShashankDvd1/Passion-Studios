using System;
using WonderForge.TinyWorld.Core.Runtime.Interfaces;

namespace WonderForge.TinyWorld.Core.Events
{
    /// <summary>
    /// Contract for the global event messaging system.
    /// </summary>
    public interface IEventBus : IGameService
    {
        /// <summary>
        /// Subscribes a handler to a specific struct event.
        /// </summary>
        void Subscribe<T>(Action<T> handler) where T : struct;

        /// <summary>
        /// Unsubscribes a handler from a specific struct event.
        /// </summary>
        void Unsubscribe<T>(Action<T> handler) where T : struct;

        /// <summary>
        /// Publishes a struct event to all subscribed handlers.
        /// </summary>
        void Publish<T>(T eventData) where T : struct;
    }
}
