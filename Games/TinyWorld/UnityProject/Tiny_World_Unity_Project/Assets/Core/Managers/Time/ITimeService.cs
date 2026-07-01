using WonderForge.TinyWorld.Core.Runtime.Interfaces;

namespace WonderForge.TinyWorld.Core.Managers.Time
{
    public interface ITimeService : IGameService
    {
        long GetOfflineSeconds();
        void UpdateLastActiveTime();
    }
}
