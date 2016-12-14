using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ContinueMenu : MonoBehaviour {
    public GameObject WinUI;
    public GameObject HitGuyUI;

    private bool win = false;
    private bool hit = false;

    // Use this for initialization
    void Start()
    {
        WinUI.SetActive(false);
        HitGuyUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
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
    }

    public void NextJob()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(1);
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
