using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelLoader : MonoBehaviour
{
    int currentSceneIndex;
    private void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
    }
    public void Play()
    {
        SceneManager.LoadScene("Level 1");
    }
    public void LoadScene()
    {
        SceneManager.LoadScene(currentSceneIndex);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
