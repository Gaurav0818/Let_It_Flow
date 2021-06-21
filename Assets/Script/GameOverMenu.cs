using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public void OnMainMenuButtonPress()
    {
        Debug.Log("menu button pressed");
        SceneManager.LoadScene(0);
    }
}
