using System.Threading.Tasks;

namespace WonderForge.TinyWorld.Core.Runtime
{
    /// <summary>
    /// Defines a contract for core systems that require structured initialization.
    /// </summary>
    public interface ICoreSystem
    {
        /// <summary>
        /// Initializes the core system.
        /// </summary>
        /// <returns>A task representing the asynchronous initialization operation.</returns>
        Task InitializeAsync();
    }
}
