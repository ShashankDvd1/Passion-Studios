namespace WonderForge.TinyWorld.Core.Runtime.Interfaces
{
    /// <summary>
    /// Implemented by services that need to be updated every frame (Tick).
    /// Avoids using Unity's Update() on MonoBehaviours to improve performance and control execution order.
    /// </summary>
    public interface IUpdatable
    {
        void Tick(float deltaTime);
    }
}
