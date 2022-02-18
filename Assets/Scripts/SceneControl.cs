using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    [SerializeField] float second;

    private void Start()
    {
        if (SceneManager.GetActiveScene().name == "0BackMenu")
        {
            Invoke("NextScene", second);
        }
    }

    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void GameExit()
    {
        Application.Quit();
    }

    public void NameScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

    public void IndexScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
