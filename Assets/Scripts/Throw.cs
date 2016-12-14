using UnityEngine;
using System.Collections;

public class Throw : MonoBehaviour {

	public GameObject reticle;
    public float throwSpeed = 2500f;
    public GameObject cam1;
    public GameObject cam2;
    public GameObject cam3;
    public GameObject knife;
    public bool acidMode = false;
    public float origZ = 17f;
    public bool rapidFire = true;

    private GameObject Instantiatedknife;
    private float speed = 1.5f;
    private Vector3 pos;
    private Vector3 origPos;
    private Vector3 origRot;
    private GameObject bod;
	private Rigidbody rb;
    private death ded;
	private float spin = 500000000f;
	private bool isThrown = false;
   
	// Use this for initialization
	void Awake(){
		rb = GetComponent<Rigidbody>();
        
        if (!acidMode)
        {
            bod = GameObject.Find("bod");
            ded = GameObject.Find("bod").GetComponent<death>();
        }else
        {
            bod = GameObject.Find("Acid");
        }
       
	}

	void Start () {
        origPos = transform.position;
        origRot = transform.localEulerAngles;
        if (!acidMode)
        {
            cam1.GetComponent<Camera>().enabled = true;
            cam2.GetComponent<Camera>().enabled = false;
            cam3.GetComponent<Camera>().enabled = false;
        }

    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (rapidFire)
        {
            if (Input.GetKeyDown("space"))
            {
                Instantiatedknife = (GameObject)Instantiate(knife, knife.transform.position, knife.transform.rotation);
                pos = reticle.transform.position;
                pos = (pos - knife.transform.position).normalized;
                Instantiatedknife.GetComponent<Rigidbody>().AddForce((pos.x) * 0.6f * throwSpeed, (pos.y) * 0.6f * throwSpeed, (pos.z) * throwSpeed);
                Instantiatedknife.GetComponent<Rigidbody>().AddTorque(new Vector3(1f, 0f, 0f) * spin);
            }
            if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x < 5.5)
            {
                transform.position -= Vector3.left * speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.RightArrow) && transform.position.x > -6)
            {
                transform.position -= Vector3.right * speed * Time.deltaTime;
            }
        }
        else if (!isThrown)
        {
            if (Input.GetKeyDown("space"))
            {
                pos = reticle.transform.position;
                pos = (pos - transform.position).normalized;
                rb.AddForce((pos.x) * throwSpeed, (pos.y) * throwSpeed, (pos.z) * throwSpeed);
                rb.AddTorque(new Vector3(1f, 0f, 0f) * spin);
                isThrown = true;
                //StartCoroutine(timer());
                if (!acidMode)
                {
                    cam1.GetComponent<Camera>().enabled = false;
                    cam2.GetComponent<Camera>().enabled = true;
                }

            }
            if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x < 5.5)
            {
                transform.position -= Vector3.left * speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.RightArrow) && transform.position.x > -6)
            {
                transform.position -= Vector3.right * speed * Time.deltaTime;
            }
        }
    }

    void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("Wall")){
            transform.position = origPos;
            transform.localEulerAngles = origRot;
            isThrown = false;
			rb.velocity = Vector3.zero;
			rb.angularVelocity = Vector3.zero;
            reticle.transform.position = new Vector3(0f, 0f, origZ);
            if (!acidMode)
            {
                cam2.GetComponent<Camera>().enabled = false;
                cam3.GetComponent<Camera>().enabled = false;
                cam1.GetComponent<Camera>().enabled = true;
            }

        }
        else if (other.gameObject.CompareTag("Human"))
        {
            Debug.Log("LOST");
            ded.iDED();
            cam1.GetComponent<PauseMenu>().hit = true;
            Destroy(reticle);
            Destroy(gameObject);
            Destroy(bod.GetComponent<BackandForth>());
            if (!acidMode)
            {
                cam2.GetComponent<Camera>().enabled = false;
                cam3.GetComponent<Camera>().enabled = false;
                cam1.GetComponent<Camera>().enabled = true;
            }
        }
        else if (other.gameObject.CompareTag("Target"))
        {
            Debug.Log("Win");
            Destroy(bod.GetComponent<BackandForth>());
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            Destroy(reticle);
            other.GetComponent<AudioSource>().Play();
            cam1.GetComponent<PauseMenu>().win = true;
            if (!acidMode)
            {
                cam2.GetComponent<Camera>().enabled = false;
                cam3.GetComponent<Camera>().enabled = false;
                cam1.GetComponent<Camera>().enabled = true;
            }
        }
        else if (other.gameObject.CompareTag("Acid"))
        {
            bod.gameObject.GetComponent<acidGuy>().dead = true;
        }
    }
}
