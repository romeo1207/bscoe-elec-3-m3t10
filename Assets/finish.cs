using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finish : MonoBehaviour {
    GameObject Player1;
    GameObject Player2;
    GameObject Pad; 

    public Color p1 = Color.blue;
     public Color p2 = Color.yellow;
    public Color landing = Color.green;
    public Renderer rend;
    public Material material;
    float distance1;
    float distance2; 
    
    void Start () {
        distance1 = 0f;
        distance2 = 0f;
        Player1 = GameObject.Find("Player");
        Player2 = GameObject.Find("Rocket");
        Pad = GameObject.Find("target");
    }


    void Update () {
        distance1 = Vector3.Distance(Player1.transform.position, Pad.transform.position);
        distance2 = Vector3.Distance(Player2.transform.position, Pad.transform.position);
        print(distance1);
        if (distance1 > 2 || distance2 > 2)
        {
            Pad.GetComponent<Renderer>().material.color = Color.red;
        }
        else if (distance2 < 2)
        {
            Pad.GetComponent<Renderer>().material.color = Color.yellow;
        }
    }
	

    public void OnCollisionEnter(Collision collision)
    {
        if (gameObject.name == "Rocket" && collision.collider.name == "target")
        {
            collision.gameObject.GetComponent<Renderer>().material.color = Color.red;
            SceneManager.LoadScene("levelTwo");
        }
    }

    public void ColorChange()
    {

    }

}
