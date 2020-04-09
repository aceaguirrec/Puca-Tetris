using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayController : MonoBehaviour
{
    [SerializeField]
    private GameObject pausePanel;



    // Start is called before the first frame update
    void Awake()
    {
        pausePanel.SetActive(false);
    }

    // Update is called once per frame
    public void PauseGame()
    {
        Time.timeScale = 0f;
        pausePanel.SetActive(true);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        pausePanel.SetActive(false);
    }

    public void QuitGame()
    {
        Time.timeScale = 1f;
        Application.LoadLevel("MainMenu");
    }
}
