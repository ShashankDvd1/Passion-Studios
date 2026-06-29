using System;
using System.IO;
using System.Threading.Tasks;
using UnityEngine;
using WonderForge.TinyWorld.Core.Runtime.Interfaces;
using WonderForge.TinyWorld.Core.Utilities;

namespace WonderForge.TinyWorld.Core.Save
{
    /// <summary>
    /// A JSON-based persistent save system. Writes data to Application.persistentDataPath.
    /// </summary>
    public class SaveService : ISaveService, IInitializable, IDisposableService
    {
        private readonly string _saveDirectory;
        private const string LOG_PREFIX = "[Save]";

        public SaveService()
        {
            // Unity's persistentDataPath is the correct location for mobile saves (iOS/Android).
            _saveDirectory = Path.Combine(Application.persistentDataPath, "Saves");
        }

        public Task InitializeAsync()
        {
            GameLogger.Log($"{LOG_PREFIX} Initializing SaveService...");
            
            if (!Directory.Exists(_saveDirectory))
            {
                Directory.CreateDirectory(_saveDirectory);
                GameLogger.Log($"{LOG_PREFIX} Created save directory at {_saveDirectory}");
            }

            return Task.CompletedTask;
        }

        public async Task SaveAsync<T>(string key, T data)
        {
            var filePath = GetFilePath(key);
            
            try
            {
                // Unity's JsonUtility must be called on the main thread, 
                // but the string writing can be offloaded.
                var json = JsonUtility.ToJson(data, prettyPrint: true);
                
                await Task.Run(async () => 
                {
                    await File.WriteAllTextAsync(filePath, json);
                });

                GameLogger.Log($"{LOG_PREFIX} Successfully saved {key}.");
            }
            catch (Exception ex)
            {
                GameLogger.LogError($"{LOG_PREFIX} Failed to save {key}: {ex.Message}");
            }
        }

        public async Task<T> LoadAsync<T>(string key)
        {
            var filePath = GetFilePath(key);

            if (!File.Exists(filePath))
            {
                GameLogger.LogWarning($"{LOG_PREFIX} Save file not found for {key}. Returning default.");
                return default;
            }

            try
            {
                string json = string.Empty;
                
                await Task.Run(async () => 
                {
                    json = await File.ReadAllTextAsync(filePath);
                });

                // JsonUtility.FromJson must run on the main thread.
                var data = JsonUtility.FromJson<T>(json);
                GameLogger.Log($"{LOG_PREFIX} Successfully loaded {key}.");
                return data;
            }
            catch (Exception ex)
            {
                GameLogger.LogError($"{LOG_PREFIX} Failed to load {key}: {ex.Message}");
                return default;
            }
        }

        public void Delete(string key)
        {
            var filePath = GetFilePath(key);
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                GameLogger.Log($"{LOG_PREFIX} Deleted save data for {key}.");
            }
        }

        public void Dispose()
        {
            GameLogger.Log($"{LOG_PREFIX} Shutting down SaveService.");
            // In the future, we might flush in-memory cached saves here.
        }

        private string GetFilePath(string key)
        {
            return Path.Combine(_saveDirectory, $"{key}.json");
        }
    }
}
