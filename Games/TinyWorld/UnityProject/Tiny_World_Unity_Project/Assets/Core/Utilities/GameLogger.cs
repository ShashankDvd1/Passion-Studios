using UnityEngine;

namespace WonderForge.TinyWorld.Core.Utilities
{
    /// <summary>
    /// Provides standardized logging functionality for the Tiny World project.
    /// Ensures consistent formatting and allows for easy toggling of log levels.
    /// </summary>
    public static class GameLogger
    {
        private const string PREFIX = "[TinyWorld]";

        /// <summary>
        /// Logs an informational message to the console.
        /// </summary>
        /// <param name="message">The message to log.</param>
        public static void Log(string message)
        {
            Debug.Log($"{PREFIX} {message}");
        }

        /// <summary>
        /// Logs a warning message to the console.
        /// </summary>
        /// <param name="message">The message to log.</param>
        public static void LogWarning(string message)
        {
            Debug.LogWarning($"{PREFIX} [WARNING] {message}");
        }

        /// <summary>
        /// Logs an error message to the console.
        /// </summary>
        /// <param name="message">The message to log.</param>
        public static void LogError(string message)
        {
            Debug.LogError($"{PREFIX} [ERROR] {message}");
        }
    }
}
