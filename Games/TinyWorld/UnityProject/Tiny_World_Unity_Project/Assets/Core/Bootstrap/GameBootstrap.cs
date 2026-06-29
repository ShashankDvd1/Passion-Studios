using System;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using WonderForge.TinyWorld.Core.Runtime;
using WonderForge.TinyWorld.Core.Utilities;
using WonderForge.TinyWorld.Core.Config;

namespace WonderForge.TinyWorld.Core.Bootstrap
{
    /// <summary>
    /// The primary entry point for the application. 
    /// Resides in the initial Bootstrap scene and handles the sequential initialization of all core systems.
    /// </summary>
    public class GameBootstrap : MonoBehaviour
    {
        [Header("Scene Configuration")]
        [Tooltip("The name of the next scene to load after initialization completes.")]
        [SerializeField] private string nextSceneName = "MainMenu";

        [Header("Dependencies")]
        [Tooltip("The root ScriptableObject containing all tuning data.")]
        [SerializeField] private GameConfig gameConfig;

        // The central runtime orchestrator.
        private GameRuntime _gameRuntime;

        private async void Start()
        {
            DontDestroyOnLoad(gameObject);
            GameLogger.Log("GameBootstrap started. Beginning initialization sequence...");

            if (gameConfig == null)
            {
                GameLogger.LogError("GameConfig is missing from GameBootstrap! Please assign it in the inspector.");
            }

            try
            {
                await InitializeSystemsAsync();
                LoadNextScene();
            }
            catch (Exception ex)
            {
                GameLogger.LogError($"Initialization failed: {ex.Message}\n{ex.StackTrace}");
                // Handle critical failure (e.g., show an error UI to the user)
            }
        }

        /// <summary>
        /// Instantiates the GameRuntime, installs services, and initializes them sequentially.
        /// </summary>
        private async Task InitializeSystemsAsync()
        {
            _gameRuntime = new GameRuntime();

            // Inject the configuration into the installer.
            RuntimeInstaller.InstallServices(_gameRuntime, gameConfig);

            // Initialize all registered IInitializable services.
            await _gameRuntime.InitializeAllAsync();

            GameLogger.Log("All core systems initialized.");
        }

        private void Update()
        {
            // Drive the runtime tick loop from this persistent MonoBehaviour.
            _gameRuntime?.Tick(Time.deltaTime);
        }

        private void OnDestroy()
        {
            _gameRuntime?.Dispose();
        }

        /// <summary>
        /// Loads the next scene once initialization is complete.
        /// </summary>
        private void LoadNextScene()
        {
            if (string.IsNullOrEmpty(nextSceneName))
            {
                GameLogger.LogWarning("Next scene name is empty. Staying in Bootstrap scene.");
                return;
            }

            GameLogger.Log($"Loading next scene: {nextSceneName}");
            SceneManager.LoadSceneAsync(nextSceneName);
        }
    }
}
