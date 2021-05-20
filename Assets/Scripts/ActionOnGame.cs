using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActionOnGame : MonoBehaviour
{
    
    public void GoToLevel(string level)
    {
        SceneManager.LoadScene(level);
    }

    public void RestartLevel(string RestartLevel)
    {
        StartCoroutine(waiterfForRestart(RestartLevel));
        Time.timeScale = 1f;

    }

    IEnumerator waiterfForRestart(string RestartLevel)
    {

        yield return new WaitForSeconds(0.8f);
        SceneManager.LoadScene(RestartLevel);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
