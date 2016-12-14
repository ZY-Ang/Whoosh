using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]

public class PlayMov2 : MonoBehaviour {
    public MovieTexture movie;
    private AudioSource audio;
    void Start()
    {
        GetComponent<RawImage>().texture = movie as MovieTexture;
        audio = GetComponent<AudioSource>();
        audio.clip = movie.audioClip;
        //movie.loop = true;
        movie.Play();
        audio.Play();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && movie.isPlaying)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else if (!movie.isPlaying)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            ;
        }
    }
}
