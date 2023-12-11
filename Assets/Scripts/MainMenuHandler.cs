using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour
{
    private void Start() {
        GameHandler.Instance.gameState = GameState.MAINMENU;
    }

    public void PlayButton() {
        SceneManager.UnloadSceneAsync("MenuScene");
        GameHandler.Instance.StartGame();
    }

    public void OpenSettingsMenu() {
        
    }
    
    public void QuitButton() {
        Application.Quit(0);
    }
}
