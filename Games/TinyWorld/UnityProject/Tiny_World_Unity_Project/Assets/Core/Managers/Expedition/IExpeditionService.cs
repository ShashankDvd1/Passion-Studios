using WonderForge.TinyWorld.Core.Runtime.Interfaces;

namespace WonderForge.TinyWorld.Core.Managers.Expedition
{
    public interface IExpeditionService : IGameService
    {
        bool IsExploring();
        int GetRemainingSeconds();
        void StartExpedition(int durationSeconds);
        bool TryCompleteExpedition();
    }
}
