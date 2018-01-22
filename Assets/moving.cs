using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour {
    Rigidbody _rigidbody;
    GameObject Sphere1;
    GameObject obstacle1;
    GameObject obstacle2;
    float distanceUp;
    float distanceDown;
    public float up = 1f;
    public float down = 1f;

    // Use this for initialization
    void Start () {
        _rigidbody = GetComponent<Rigidbody>();
        Sphere1 = GameObject.Find("Sphere1");
        distanceDown = 0f;
        distanceUp = 0f;
        obstacle1 = GameObject.Find("obstacle_14");
        obstacle2 = GameObject.Find("obstacle_13");
    }
	
	// Update is called once per frame
	void Update () {
        distanceDown = Vector3.Distance(Sphere1.transform.position, obstacle1.transform.position);
        distanceUp = Vector3.Distance(Sphere1.transform.position, obstacle2.transform.position);

            if (distanceDown < down)
        {
            _rigidbody.AddRelativeForce(Vector3.up * 200 * Time.deltaTime);
        }
            else if (distanceUp < up)
        {
            _rigidbody.AddRelativeForce(Vector3.down * 200 * Time.deltaTime);
        }

	}
}
