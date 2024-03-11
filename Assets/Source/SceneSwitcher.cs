using UnityEngine;
using UnityEngine.SceneManagement;

public static class SceneSwitcher
{
    public static void Switch(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public static void Reload()
    {
        SceneManager.LoadScene(GetSceneName());
    }

    public static string GetSceneName()
    {
        return SceneManager.GetActiveScene().name;
    }
}