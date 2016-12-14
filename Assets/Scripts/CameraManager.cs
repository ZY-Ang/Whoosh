using UnityEngine;
using System.Collections;

public class CameraManager : MonoBehaviour {

	public GameObject cam1;
	public GameObject cam2;
	public GameObject cam3;
	// Use this for initialization
	void Start () {
		cam1.GetComponent<Camera>().enabled = true;
		cam2.GetComponent<Camera>().enabled = false;
		cam3.GetComponent<Camera>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.LeftShift) && cam2.GetComponent<Camera>().enabled == true){
			cam3.GetComponent<Camera>().enabled = true;
			cam2.GetComponent<Camera>().enabled = false;
			cam1.GetComponent<Camera>().enabled = false;
		}
	}
}
