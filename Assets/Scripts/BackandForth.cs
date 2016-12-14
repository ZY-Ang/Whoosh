using UnityEngine;
using System.Collections;

public class BackandForth : MonoBehaviour {
    public float speed = 2.0f;
    public float limit = 2.0f;

    private Vector3 startPos;
	// Use this for initialization
	void Start () {
        startPos = transform.position;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Vector3 velo = startPos;
        velo.x += limit * Mathf.Sin(Time.time * speed);
        transform.position = velo;
	}
}
