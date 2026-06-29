using System.Threading.Tasks;
using UnityEngine;
using WonderForge.TinyWorld.Core.Runtime.Interfaces;
using WonderForge.TinyWorld.Core.Utilities;

namespace WonderForge.TinyWorld.Core.Managers.Audio
{
    public class AudioService : IAudioService, IInitializable
    {
        private const string LOG_PREFIX = "[Audio]";

        public Task InitializeAsync()
        {
            GameLogger.Log($"{LOG_PREFIX} Audio Service Initialized.");
            // In the future: Load audio mixers, initialize object pools for SFX sources.
            return Task.CompletedTask;
        }

        public void PlayMusic(string trackName, bool loop = true)
        {
            GameLogger.Log($"{LOG_PREFIX} Playing Music: {trackName}");
        }

        public void PlaySFX(string clipName)
        {
            GameLogger.Log($"{LOG_PREFIX} Playing SFX: {clipName}");
        }

        public void StopMusic()
        {
            GameLogger.Log($"{LOG_PREFIX} Stopping Music.");
        }

        public void SetMasterVolume(float volume)
        {
            GameLogger.Log($"{LOG_PREFIX} Setting Master Volume to {volume}.");
        }
    }
}
