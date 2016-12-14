using UnityEngine;
using System.Collections;

public class Gamemanager : MonoBehaviour {
    public float diff = 0;
    // Use this for initialization
    void Start () {
	
	}
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    // Update is called once per frame
    void Update () {
	
	}
}
