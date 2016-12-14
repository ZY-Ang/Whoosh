using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {
    public GameObject PauseUI;
    public GameObject WinUI;
    public GameObject HitGuyUI;

    public bool win = false;
    public bool hit = false;
    public bool paused = false;

	void Start () {
        PauseUI.SetActive(false);
        HitGuyUI.SetActive(false);
        WinUI.SetActive(false);
	}
	
	void Update () {


        if (Input.GetKeyDown(KeyCode.O))
        {
            win = !win;
        }

        if (win)
        {
            WinUI.SetActive(true);
            Time.timeScale = 0;
        }

        if (!win)
        {
            WinUI.SetActive(false);
            Time.timeScale = 1;
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            hit = !hit;
        }

        if (hit)
        {
            HitGuyUI.SetActive(true);
            Time.timeScale = 0;
        }

        if (!hit)
        {
            HitGuyUI.SetActive(false);
            Time.timeScale = 1;
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            paused = !paused;
        }

        if (paused)
        {
            PauseUI.SetActive(true);
            Time.timeScale = 0;
        }

        if (!paused)
        {
            PauseUI.SetActive(false);
            Time.timeScale = 1;
        }
    }

    public void Resume()
    {
        paused = !paused;
    }

    public void NextJob()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(2);
    }
    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
