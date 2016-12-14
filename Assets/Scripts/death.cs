using UnityEngine;
using System.Collections;

public class death : MonoBehaviour {
    private GameObject bod;
    private GameObject head;
    private GameObject rleg;
    private GameObject leftleg;
    private GameObject rightup;
    private GameObject right;
    private GameObject leftup;
    private GameObject left;
    private GameObject apple;
    private AudioSource ahhh;
    private AudioSource app;

    public float force = 10000f;

    // Use this for initialization
    void Start () {
        bod = GameObject.Find("bod");
        head = GameObject.Find("head");
        rleg = GameObject.Find("rleg");
        leftleg = GameObject.Find("leftleg");
        rightup = GameObject.Find("rightup");
        right = GameObject.Find("right");
        leftup = GameObject.Find("Leftup");
        left = GameObject.Find("left");
        apple = GameObject.Find("Apple");
        ahhh = GetComponent<AudioSource>();
        app = apple.GetComponent<AudioSource>();
        
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    public void iDED()
    {

        apple.GetComponent<Rigidbody>().AddForce(0,force,0);
        bod.AddComponent<Rigidbody2D>();
        bod.GetComponent<Rigidbody2D>().AddForce(transform.up * force);
        bod.GetComponent<Rigidbody2D>().AddForce(transform.right * -force);
        head.AddComponent<Rigidbody2D>();
        head.GetComponent<Rigidbody2D>().AddForce(transform.up * force);
        head.GetComponent<Rigidbody2D>().AddForce(transform.right * force);
        rleg.AddComponent<Rigidbody2D>();
        rleg.GetComponent<Rigidbody2D>().AddForce(transform.right * force);
        leftleg.AddComponent<Rigidbody2D>();
        leftleg.GetComponent<Rigidbody2D>().AddForce(transform.right * -force);
        rightup.AddComponent<Rigidbody2D>();
        rightup.GetComponent<Rigidbody2D>().AddForce(transform.right * force);
        right.AddComponent<Rigidbody2D>();
        right.GetComponent<Rigidbody2D>().AddForce(transform.right * force);
        leftup.AddComponent<Rigidbody2D>();
        leftup.GetComponent<Rigidbody2D>().AddForce(transform.right * -force);
        left.AddComponent<Rigidbody2D>();
        left.GetComponent<Rigidbody2D>().AddForce(transform.right * -force);
        StartCoroutine(sound());
    }
    IEnumerator sound()
    {
        Debug.Log("sound");
        ahhh.Play();
        yield return new WaitForSeconds(0.5f);
        app.Play();
    }
}
