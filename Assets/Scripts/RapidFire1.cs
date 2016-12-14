using UnityEngine;
using System.Collections;

public class RapidFire1 : MonoBehaviour {

	private GameObject bod;
	//private death ded;
	// Use this for initialization
	void Awake(){
        bod = GameObject.Find("body");
        //ded = GameObject.Find("bod").GetComponent<death>();
    }
	void Start () {
      
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("Wall")){
			Destroy(gameObject);
        }
        else if (other.gameObject.CompareTag("Target"))
        {
            Debug.Log("Win");
            Destroy(bod.GetComponent<BackandForth>());
        }
        else if (other.gameObject.CompareTag("Acid"))
        {
            Debug.Log("Acid");
            bod.GetComponent<acidGuy>().dead = true;
        }
    }
}
