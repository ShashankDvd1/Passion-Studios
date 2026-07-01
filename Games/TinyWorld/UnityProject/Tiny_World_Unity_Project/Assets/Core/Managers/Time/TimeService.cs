using System;
using System.Threading.Tasks;
using WonderForge.TinyWorld.Core.Runtime.Interfaces;
using WonderForge.TinyWorld.Core.Save;
using WonderForge.TinyWorld.Core.Utilities;
using UnityEngine;

namespace WonderForge.TinyWorld.Core.Managers.Time
{
    public class TimeService : ITimeService, IInitializable, IDisposableService
    {
        private const string SAVE_KEY = "TimeState";
        private readonly ISaveService _saveService;
        private TimeData _data;
        private long _offlineSeconds = 0;

        public TimeService(ISaveService saveService)
        {
            _saveService = saveService;
        }

        public async Task InitializeAsync()
        {
            _data = await _saveService.LoadAsync<TimeData>(SAVE_KEY);
            if (_data == null)
            {
                _data = new TimeData();
                _data.LastActiveTimeBinary = DateTime.UtcNow.ToBinary();
            }
            else
            {
                DateTime lastTime = DateTime.FromBinary(_data.LastActiveTimeBinary);
                _offlineSeconds = (long)(DateTime.UtcNow - lastTime).TotalSeconds;
                
                // Prevent negative time if player changes device clock backwards
                if (_offlineSeconds < 0) _offlineSeconds = 0; 
                
                GameLogger.Log($"[TimeService] Player was offline for {_offlineSeconds} seconds.");
            }

            UpdateLastActiveTime();
            
            // Hook into Unity's exit event to save the exact moment the app closes
            Application.quitting += OnApplicationQuitting;
        }

        public long GetOfflineSeconds()
        {
            return _offlineSeconds;
        }

        public void UpdateLastActiveTime()
        {
            _data.LastActiveTimeBinary = DateTime.UtcNow.ToBinary();
            _ = _saveService.SaveAsync(SAVE_KEY, _data);
        }

        private void OnApplicationQuitting()
        {
            UpdateLastActiveTime();
        }

        public void Dispose()
        {
            Application.quitting -= OnApplicationQuitting;
        }
    }
}
