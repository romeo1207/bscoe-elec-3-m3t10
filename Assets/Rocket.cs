using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rocket : MonoBehaviour {
    GameObject Pad;
    GameObject RocketShip;
    Rigidbody _rigidbody;
    AudioSource _audioSource;

    public Color color = Color.red;
    public Renderer rend;
    public Material material;
    
    bool _isSoundPlaying = false;
    public Vector3 position1 = new Vector3(-11.32f, 2.63f, 0f); //original position
    //private Quaternion position = new Quaternion(0f, 0f, 0f, 0f);

    public float mainThrust = 140f; //movement up
    public float rcsThrust = 140f; //rotation left/right

    bool ColTog = true; //COllission Toggle

    void Start () {
        _rigidbody = GetComponent<Rigidbody>();
        _audioSource = GetComponent<AudioSource>();
        RocketShip = GameObject.Find("Player");
        Pad = GameObject.Find("target3");
        
    }
	
	// Update is called once per frame
	void Update () {
        ProcessInput();
        collissionToggle();
    }


    public void collissionToggle() //CollissionToggle Function
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            if (ColTog)
            {
                ColTog = false;
            }
            else
            {
                ColTog = true;
            }
        }
    }


    public void ProcessInput() //Function for Controls
    {
        if (Input.GetKey(KeyCode.Space))
        {
            _rigidbody.AddRelativeForce(Vector3.up * mainThrust * Time.deltaTime);
          //  print("fly");
            if(!_isSoundPlaying && Input.GetKeyDown(KeyCode.Space)){
                _audioSource.Play();
                _isSoundPlaying = true;
            }
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            _audioSource.Pause();
            _isSoundPlaying = false;
            print("pumasok");
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * rcsThrust * Time.deltaTime);
            //print("left");
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.forward * rcsThrust * Time.deltaTime);
           // print("right");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (ColTog)
        {
            print("sdgfsdg");
            if (gameObject.name == "Player" && collision.collider.tag == "obstacle")
            {
                RocketShip.transform.position = position1;
                _rigidbody.angularVelocity = new Vector3(0f, 0f, 0f);
                _rigidbody.velocity = new Vector3(0f, 0f, 0f);
                RocketShip.transform.rotation = Quaternion.identity;
                SceneManager.LoadScene("levelOne");
            }

            else if (gameObject.name == "Player" && collision.collider.name == "target")
            {
                SceneManager.LoadScene("levelTwo");
            }
            else if (gameObject.name == "Player" && collision.collider.name == "target2")
            {
                SceneManager.LoadScene("levelThree");
            }
            else if (gameObject.name == "Player" && collision.collider.name == "target3")
            {
                Pad.GetComponent<Renderer>().material.color = Color.green;
            }
        }
        
    }

}
