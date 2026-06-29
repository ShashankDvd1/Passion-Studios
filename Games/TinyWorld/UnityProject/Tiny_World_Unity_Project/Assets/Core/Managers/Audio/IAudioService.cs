using UnityEngine;
using WonderForge.TinyWorld.Core.Runtime.Interfaces;

namespace WonderForge.TinyWorld.Core.Managers.Audio
{
    public interface IAudioService : IGameService
    {
        void PlayMusic(string trackName, bool loop = true);
        void PlaySFX(string clipName);
        void StopMusic();
        void SetMasterVolume(float volume);
    }
}
