using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {
    public GameObject StartMenuUI;
    private Gamemanager manager;
    public Toggle acid;
    public Slider slide;
    public float difficulty { get; set; }

    void start()
    {
        
    }
    public void StartGame()
    {
        slide = GameObject.Find("Difficulty").GetComponent<Slider>();
        acid = GameObject.Find("Acid").GetComponent<Toggle>();
        manager = GameObject.Find("GameManager").GetComponent<Gamemanager>();
        manager.diff = slide.value;
        Debug.Log(slide.value);
        if (acid.isOn == true)
        {
            SceneManager.LoadScene(5); //load acid scene
        } else
        {
            SceneManager.LoadScene(3); //load other scene
        }
        
    }

   
    public void ExitGame()
    {
        Application.Quit();
    }

}
