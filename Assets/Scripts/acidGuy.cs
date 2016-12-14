using UnityEngine;
using System.Collections;

public class acidGuy : MonoBehaviour {
  
    //private Animator anim;
    public Animator anim;
    public bool dead = false;
    private AudioSource ahh;
    // Use this for initialization
    void Start () {
        ahh = GetComponent<AudioSource>();
        anim = transform.gameObject.GetComponent<Animator>();

    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (dead)
        {
            StartCoroutine(DED());
        }

	
	}
    IEnumerator DED()
    {
        ahh.Play();
        anim.SetBool("Dead", true);
        yield return new WaitForSeconds(3f);
        anim.SetBool("Dead", false);
    }
}
