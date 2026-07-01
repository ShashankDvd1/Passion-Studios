using System;
using System.Threading.Tasks;
using WonderForge.TinyWorld.Core.Runtime.Interfaces;
using WonderForge.TinyWorld.Core.Utilities;

namespace WonderForge.TinyWorld.Core.Managers.Ads
{
    public class MockAdService : IAdService, IInitializable
    {
        public Task InitializeAsync()
        {
            GameLogger.Log("[MockAdService] Initialized in Mock Mode.");
            return Task.CompletedTask;
        }

        public bool IsAdAvailable()
        {
            return true; // Always true for editor testing
        }

        public async void ShowRewardedAd(Action onCompleted, Action onFailed)
        {
            GameLogger.Log("[MockAdService] Simulating watching an ad (2 seconds)...");
            
            // Wait for 2 seconds to simulate ad playing
            await Task.Delay(2000);
            
            GameLogger.Log("[MockAdService] Ad simulation finished. Granting reward.");
            onCompleted?.Invoke();
        }
    }
}
