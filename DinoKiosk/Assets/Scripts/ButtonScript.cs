using UnityEngine;
using UnityEngine.SceneManagement; // Required for SceneManager

public class SceneLoader : MonoBehaviour
{
    // A public function that can be called by the UI button
    public void LoadSpecificScene(string sceneName)
    {
        // Load the scene by its name as specified in the Build Settings
        SceneManager.LoadScene(sceneName);
    }

    // Optional: A function to load the next scene in the Build Settings order
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}