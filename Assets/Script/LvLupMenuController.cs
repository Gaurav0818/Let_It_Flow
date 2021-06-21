using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvLupMenuController : MonoBehaviour
{
    public void OnContinueButtonPress()
    {
        Scene sceneLoaded = SceneManager.GetActiveScene();
        SceneManager.LoadScene(sceneLoaded.buildIndex + 1);
    }
    public void OnMainMenuButtonPress()
    {
        SceneManager.LoadScene(0);
    }
    public void OnRestartButtonPress()
    {
        Scene sceneLoaded = SceneManager.GetActiveScene();
        SceneManager.LoadScene(sceneLoaded.buildIndex );
    }
}
