using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadLevelTwo : MonoBehaviour {

    GameObject Ship;
    GameObject Pad;
    GameObject Pad2;

    public float warningDistance = 5f;
    public Color change = Color.yellow;
    public Renderer rend;
    public Material material;
    public float distance;

	void Start () {
        distance = 0f;
        Ship = GameObject.Find("Player");
        Pad = GameObject.FindWithTag("target");
	}

    // Update is called once per frame
  

    void Update () {

        distance = Vector3.Distance(Ship.transform.position, Pad.transform.position);

        if (distance < warningDistance && distance>1.8)
        {
            Pad.GetComponent<Renderer>().material.color = Color.blue;
        }
        else if (distance > 4.5)
        {
            Pad.GetComponent<Renderer>().material.color = Color.red;
        }
        else if (distance<1.7)
        {
            Pad.GetComponent<Renderer>().material.color = Color.green;
        }
	}

}
