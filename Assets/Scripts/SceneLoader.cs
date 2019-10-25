using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
  public void NextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void ScenarioSimBuildScene()
    {
        SceneManager.LoadScene(2);
    }

    public void MainScene()
    {       
        SceneManager.LoadScene(0);
    }
}
