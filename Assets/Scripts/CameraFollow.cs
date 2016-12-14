using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public GameObject player;

	private Vector3 pos_diff;
	private bool shot = false;
	// Use this for initialization
	void Start () {
		pos_diff = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(player.transform.position.x + pos_diff.x, player.transform.position.y + pos_diff.y, player.transform.position.z + 2*pos_diff.z);
	}
}