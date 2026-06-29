using System;
using System.Collections.Generic;
using WonderForge.TinyWorld.Core.Runtime.Interfaces;
using WonderForge.TinyWorld.Core.Utilities;

namespace WonderForge.TinyWorld.Core.Events
{
    /// <summary>
    /// A zero-allocation (on publish) event messaging system for decoupled communication.
    /// Uses generics and struct constraints to avoid boxing.
    /// </summary>
    public class EventBus : IEventBus, IDisposableService
    {
        private readonly Dictionary<Type, Delegate> _subscribers = new Dictionary<Type, Delegate>();

        public void Subscribe<T>(Action<T> handler) where T : struct
        {
            var eventType = typeof(T);

            if (_subscribers.TryGetValue(eventType, out var existingDelegate))
            {
                _subscribers[eventType] = Delegate.Combine(existingDelegate, handler);
            }
            else
            {
                _subscribers[eventType] = handler;
            }
        }

        public void Unsubscribe<T>(Action<T> handler) where T : struct
        {
            var eventType = typeof(T);

            if (_subscribers.TryGetValue(eventType, out var existingDelegate))
            {
                var newDelegate = Delegate.Remove(existingDelegate, handler);
                
                if (newDelegate == null)
                {
                    _subscribers.Remove(eventType);
                }
                else
                {
                    _subscribers[eventType] = newDelegate;
                }
            }
        }

        public void Publish<T>(T eventData) where T : struct
        {
            var eventType = typeof(T);

            if (_subscribers.TryGetValue(eventType, out var existingDelegate))
            {
                // We safely cast the delegate back to Action<T> and invoke it.
                // This approach avoids boxing the struct eventData.
                var action = existingDelegate as Action<T>;
                action?.Invoke(eventData);
            }
        }

        public void Dispose()
        {
            GameLogger.Log("[EventBus] Clearing all subscriptions on disposal.");
            _subscribers.Clear();
        }
    }
}
