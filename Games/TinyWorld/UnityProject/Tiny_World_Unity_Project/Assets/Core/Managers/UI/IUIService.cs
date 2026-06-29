using WonderForge.TinyWorld.Core.Runtime.Interfaces;

namespace WonderForge.TinyWorld.Core.Managers.UI
{
    public interface IUIService : IGameService
    {
        void ShowScreen(string screenId);
        void HideScreen(string screenId);
        void CloseAllScreens();
    }
}
