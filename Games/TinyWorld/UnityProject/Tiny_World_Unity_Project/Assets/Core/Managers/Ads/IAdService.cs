using System;
using WonderForge.TinyWorld.Core.Runtime.Interfaces;

namespace WonderForge.TinyWorld.Core.Managers.Ads
{
    public interface IAdService : IGameService
    {
        bool IsAdAvailable();
        void ShowRewardedAd(Action onCompleted, Action onFailed);
    }
}
