using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{

    public GameObject pauseMenu;

    
    public Button btn_Restart, btn_Exit, btn_goRestart, btn_goExit;

    
    void Start()
    {
        
        GetComponent<Button>().onClick.AddListener(TogglePauseMenu);

        
        btn_Restart.onClick.AddListener(loadNewScene);
        btn_Exit.onClick.AddListener(Application.Quit);
        pauseMenu.SetActive(false);

        
        btn_goRestart.onClick.AddListener(loadNewScene);
        btn_goExit.onClick.AddListener(Application.Quit);

    }

    void TogglePauseMenu()
    {
        if (pauseMenu.activeSelf)
        {
            pauseMenu.SetActive(false);
        }
        else
        {
            pauseMenu.SetActive(true);
        }
    }

    void loadNewScene()
    {
        SceneManager.LoadScene("MainScene", LoadSceneMode.Single);
    }
}
