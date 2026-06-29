using System.Threading.Tasks;
using WonderForge.TinyWorld.Core.Runtime.Interfaces;
using WonderForge.TinyWorld.Core.Utilities;

namespace WonderForge.TinyWorld.Core.Managers.UI
{
    public class UIService : IUIService, IInitializable
    {
        private const string LOG_PREFIX = "[UI]";

        public Task InitializeAsync()
        {
            GameLogger.Log($"{LOG_PREFIX} UI Service Initialized.");
            return Task.CompletedTask;
        }

        public void ShowScreen(string screenId)
        {
            GameLogger.Log($"{LOG_PREFIX} Showing Screen: {screenId}");
        }

        public void HideScreen(string screenId)
        {
            GameLogger.Log($"{LOG_PREFIX} Hiding Screen: {screenId}");
        }

        public void CloseAllScreens()
        {
            GameLogger.Log($"{LOG_PREFIX} Closing all screens.");
        }
    }
}
