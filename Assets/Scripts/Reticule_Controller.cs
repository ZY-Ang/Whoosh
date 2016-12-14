using UnityEngine;
using System.Collections;

public class Reticule_Controller : MonoBehaviour {
    public float minX;
    public float minY;
    public float maxX;
    public float maxY;
    public float driftSpeed = 1;
    public float speed = 1;

    private float currentX;
    private float currentY;

    private float newX;
    private float newY;

    private float step;
    private float currentZ;
    private Vector3 target;


	// Use this for initialization
	void Start () {
        currentZ = transform.position.z;

    }
	
	// Update is called once per frame
	void FixedUpdate () {
        step = Random.Range(1, driftSpeed) * Time.deltaTime;
        newX = Random.Range(minX,maxX);
        newY = Random.Range(minY,maxY);
        target = new Vector3(newX,newY,currentZ);
        transform.position = Vector3.MoveTowards(transform.position,target,step);

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }


    }
}
