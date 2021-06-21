using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsMenuController : MonoBehaviour
{
    public GameObject controls;
    public GameObject gameElements;
    public void OnMainMenuButtonPress()
    {
        Debug.Log("menu button pressed");
        SceneManager.LoadScene(0);
    }

    public void OnControlsButtonPress()
    {
        controls.SetActive(true);
    }
    public void OnGameElementsButtonPress()
    {
        gameElements.SetActive(true);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Scene sceneLoaded = SceneManager.GetActiveScene();
            SceneManager.LoadScene(sceneLoaded.buildIndex);
        }
    }
}
