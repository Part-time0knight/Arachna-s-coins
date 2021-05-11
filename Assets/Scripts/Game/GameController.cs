using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public const string GAME = "game";
    public const string MENU = "menu";
    private string scene;
    private PausePanel pause;
    private AsyncOperation operation;
    private void Start()
    {
        pause = PanelController.pausePanel.GetComponent<PausePanel>();
    }
    public void InGame()
    {
        pause.Show(LoadGame);
        scene = GAME;
    }
    public void InMenu()
    {
        pause.Show(LoadGame);
        scene = MENU;
    }
    private void LoadGame()
    {
        LoadPanel _loadPanel = PanelController.loadPanel.GetComponent<LoadPanel>();
        _loadPanel.Show(null);
        pause.Hide(StartLoad);
        
    }
    private void StartLoad()
    {
        StartCoroutine(Load());
    }
    private IEnumerator Load()
    {
        operation = SceneManager.LoadSceneAsync(scene);
        bool hide = false;
        operation.allowSceneActivation = false;
        while (!hide)
        {
            if (operation.progress == 0.9f)
            {
                pause.Show(EndLoad);
                hide = true;
            }
            yield return null;
        }
    }
    private void EndLoad()
    {
        operation.allowSceneActivation = true;
    }
}
