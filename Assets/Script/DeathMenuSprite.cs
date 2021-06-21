using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DeathMenuSprite : MonoBehaviour
{

    public void OnMainMenuButtonPress()
    {
        Debug.Log("menu button pressed");
        SceneManager.LoadScene(0);
    }
    public void OnRestartButtonPress()
    {
        Scene sceneLoaded = SceneManager.GetActiveScene();
        SceneManager.LoadScene(sceneLoaded.buildIndex);
    }
}
