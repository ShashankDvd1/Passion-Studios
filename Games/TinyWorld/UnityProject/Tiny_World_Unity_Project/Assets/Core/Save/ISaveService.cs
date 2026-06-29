using System.Threading.Tasks;
using WonderForge.TinyWorld.Core.Runtime.Interfaces;

namespace WonderForge.TinyWorld.Core.Save
{
    /// <summary>
    /// Contract for the persistent data layer.
    /// </summary>
    public interface ISaveService : IGameService
    {
        /// <summary>
        /// Asynchronously saves an object to persistent storage.
        /// </summary>
        /// <param name="key">The unique identifier for this save data.</param>
        /// <param name="data">The data object to serialize and save.</param>
        Task SaveAsync<T>(string key, T data);

        /// <summary>
        /// Asynchronously loads an object from persistent storage.
        /// </summary>
        /// <param name="key">The unique identifier for this save data.</param>
        /// <returns>The deserialized data object, or default if not found.</returns>
        Task<T> LoadAsync<T>(string key);
        
        /// <summary>
        /// Deletes the save data associated with the key.
        /// </summary>
        void Delete(string key);
    }
}
