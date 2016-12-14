using UnityEngine;
using System.Collections;

public class CameraPerspective : MonoBehaviour {

	public GameObject player;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt(player.transform);
		transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z);
	}
}