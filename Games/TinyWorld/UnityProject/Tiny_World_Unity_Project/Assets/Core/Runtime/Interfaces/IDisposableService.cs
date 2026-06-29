namespace WonderForge.TinyWorld.Core.Runtime.Interfaces
{
    /// <summary>
    /// Implemented by services that allocate unmanaged resources or event subscriptions 
    /// that must be cleaned up when the game or service shuts down.
    /// </summary>
    public interface IDisposableService
    {
        void Dispose();
    }
}
