using System.Threading.Tasks;

namespace WonderForge.TinyWorld.Core.Runtime.Interfaces
{
    /// <summary>
    /// Implemented by services that require asynchronous initialization before the game starts.
    /// </summary>
    public interface IInitializable
    {
        Task InitializeAsync();
    }
}
