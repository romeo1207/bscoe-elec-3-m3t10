using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerTwo : MonoBehaviour
{
    GameObject RocketShipSecond;
    public Color color = Color.red;
    public Renderer rend;
    public Material material;
    public Vector3 position1 = new Vector3(-9.844f, 2.68f, 0f);
    //private Quaternion position = new Quaternion(0f,0f,0f,0f);
    Rigidbody _rigidbody;
    AudioSource _audioSource;
    bool _isSoundPlaying = false;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _audioSource = GetComponent<AudioSource>();
        RocketShipSecond = GameObject.Find("Rocket");

    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();
    }

    private void ProcessInput()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            _rigidbody.AddRelativeForce(Vector3.up * 2);
            print("fly");
            if (!_isSoundPlaying)
            {
                _audioSource.Play();
                _isSoundPlaying = true;
            }

            else
            {
                _audioSource.Play();
                _isSoundPlaying = false;
            }
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.forward * 2);
            print("left");
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(-Vector3.forward * 2);
            print("right");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (gameObject.name == "Rocket" && collision.collider.name == "obstacle 2")
        {
            RocketShipSecond.transform.position = position1;
            _rigidbody.angularVelocity = new Vector3(0f, 0f, 0f);
            _rigidbody.velocity = new Vector3(0f, 0f, 0f);
            RocketShipSecond.transform.rotation = Quaternion.identity;

        }
        else if (gameObject.name == "Rocket" && collision.collider.name == "obstacle 3")
        {
            RocketShipSecond.transform.position = position1;
            _rigidbody.angularVelocity = new Vector3(0f, 0f, 0f);
            _rigidbody.velocity = new Vector3(0f, 0f, 0f);
            RocketShipSecond.transform.rotation = Quaternion.identity;

        }
        else if (gameObject.name == "Rocket" && collision.collider.name == "obstacle 4")
        {
            RocketShipSecond.transform.position = position1;
            _rigidbody.angularVelocity = new Vector3(0f, 0f, 0f);
            _rigidbody.velocity = new Vector3(0f, 0f, 0f);
            RocketShipSecond.transform.rotation = Quaternion.identity;
        }
        else if (gameObject.name == "Rocket" && collision.collider.name == "obstacle 5")
        {
            RocketShipSecond.transform.position = position1;
            _rigidbody.angularVelocity = new Vector3(0f, 0f, 0f);
            _rigidbody.velocity = new Vector3(0f, 0f, 0f);
            RocketShipSecond.transform.rotation = Quaternion.identity;

        }
        else if (gameObject.name == "Rocket" && collision.collider.name == "obstacle 2")
        {
            RocketShipSecond.transform.position = position1;
            _rigidbody.angularVelocity = new Vector3(0f, 0f, 0f);
            _rigidbody.velocity = new Vector3(0f, 0f, 0f);
            RocketShipSecond.transform.rotation = Quaternion.identity;

        }
        else if (gameObject.name == "Rocket" && collision.collider.name == "obstacle 6")
        {
            RocketShipSecond.transform.position = position1;
            _rigidbody.angularVelocity = new Vector3(0f, 0f, 0f);
            _rigidbody.velocity = new Vector3(0f, 0f, 0f);
            RocketShipSecond.transform.rotation = Quaternion.identity;

        }
        else if (gameObject.name == "Rocket" && collision.collider.name == "obstacle 7")
        {
            RocketShipSecond.transform.position = position1;
            _rigidbody.angularVelocity = new Vector3(0f, 0f, 0f);
            _rigidbody.velocity = new Vector3(0f, 0f, 0f);
            RocketShipSecond.transform.rotation = Quaternion.identity;

        }
        else if (gameObject.name == "Rocket" && collision.collider.name == "obstacle 2")
        {
            RocketShipSecond.transform.position = position1;
            _rigidbody.angularVelocity = new Vector3(0f, 0f, 0f);
            _rigidbody.velocity = new Vector3(0f, 0f, 0f);
            RocketShipSecond.transform.rotation = Quaternion.identity;

        }
        else if (gameObject.name == "Rocket" && collision.collider.name == "obstacle 8")
        {
            RocketShipSecond.transform.position = position1;
            _rigidbody.angularVelocity = new Vector3(0f, 0f, 0f);
            _rigidbody.velocity = new Vector3(0f, 0f, 0f);
            RocketShipSecond.transform.rotation = Quaternion.identity;

        }
        else if (gameObject.name == "Rocket" && collision.collider.name == "obstacle 9")
        {
            RocketShipSecond.transform.position = position1;
            _rigidbody.angularVelocity = new Vector3(0f, 0f, 0f);
            _rigidbody.velocity = new Vector3(0f, 0f, 0f);
            RocketShipSecond.transform.rotation = Quaternion.identity;

        }
        else if (gameObject.name == "Rocket" && collision.collider.name == "obstacle 10")
        {
            RocketShipSecond.transform.position = position1;
            _rigidbody.angularVelocity = new Vector3(0f, 0f, 0f);
            _rigidbody.velocity = new Vector3(0f, 0f, 0f);
            RocketShipSecond.transform.rotation = Quaternion.identity;

        }
        else if (gameObject.name == "Rocket" && collision.collider.name == "obstacle 11")
        {
            RocketShipSecond.transform.position = position1;
            _rigidbody.angularVelocity = new Vector3(0f, 0f, 0f);
            _rigidbody.velocity = new Vector3(0f, 0f, 0f);
            RocketShipSecond.transform.rotation = Quaternion.identity;

        }
        else if (gameObject.name == "Rocket" && collision.collider.name == "obstacle 12")
        {
            RocketShipSecond.transform.position = position1;
            _rigidbody.angularVelocity = new Vector3(0f, 0f, 0f);
            _rigidbody.velocity = new Vector3(0f, 0f, 0f);
            RocketShipSecond.transform.rotation = Quaternion.identity;

        }
        else if (gameObject.name == "Rocket" && collision.collider.name == "obstacle 13")
        {
            RocketShipSecond.transform.position = position1;
            _rigidbody.angularVelocity = new Vector3(0f, 0f, 0f);
            _rigidbody.velocity = new Vector3(0f, 0f, 0f);
            RocketShipSecond.transform.rotation = Quaternion.identity;

        }
        else if (gameObject.name == "Rocket" && collision.collider.name == "obstacle 14")
        {
            RocketShipSecond.transform.position = position1;
            _rigidbody.angularVelocity = new Vector3(0f, 0f, 0f);
            _rigidbody.velocity = new Vector3(0f, 0f, 0f);
            RocketShipSecond.transform.rotation = Quaternion.identity;

        }
        else if (gameObject.name == "Rocket" && collision.collider.name == "obstacle 15")
        {
            RocketShipSecond.transform.position = position1;
            _rigidbody.angularVelocity = new Vector3(0f, 0f, 0f);
            _rigidbody.velocity = new Vector3(0f, 0f, 0f);
            RocketShipSecond.transform.rotation = Quaternion.identity;
        }
        else if (gameObject.name == "Rocket" && collision.collider.name == "obstacle 17")
        {
            RocketShipSecond.transform.position = position1;
            _rigidbody.angularVelocity = new Vector3(0f, 0f, 0f);
            _rigidbody.velocity = new Vector3(0f, 0f, 0f);
            RocketShipSecond.transform.rotation = Quaternion.identity;
        }
        else if (gameObject.name == "Rocket" && collision.collider.name == "obstacle 18")
        {
            RocketShipSecond.transform.position = position1;
            _rigidbody.angularVelocity = new Vector3(0f, 0f, 0f);
            _rigidbody.velocity = new Vector3(0f, 0f, 0f);
            RocketShipSecond.transform.rotation = Quaternion.identity;
        }
        else if (gameObject.name == "Rocket" && collision.collider.name == "obstacle 19")
        {
            RocketShipSecond.transform.position = position1;
            _rigidbody.angularVelocity = new Vector3(0f, 0f, 0f);
            _rigidbody.velocity = new Vector3(0f, 0f, 0f);
            RocketShipSecond.transform.rotation = Quaternion.identity;
        }
        else if (gameObject.name == "Rocket" && collision.collider.name == "obstacle 20")
        {
            RocketShipSecond.transform.position = position1;
            _rigidbody.angularVelocity = new Vector3(0f, 0f, 0f);
            _rigidbody.velocity = new Vector3(0f, 0f, 0f);
            RocketShipSecond.transform.rotation = Quaternion.identity;
        }
        else if (gameObject.name == "Rocket" && collision.collider.name == "obstacle 21")
        {
            RocketShipSecond.transform.position = position1;
            _rigidbody.angularVelocity = new Vector3(0f, 0f, 0f);
            _rigidbody.velocity = new Vector3(0f, 0f, 0f);
            RocketShipSecond.transform.rotation = Quaternion.identity;
        }
        else if (gameObject.name == "Rocket" && collision.collider.name == "obstacle 22")
        {
            RocketShipSecond.transform.position = position1;
            _rigidbody.angularVelocity = new Vector3(0f, 0f, 0f);
            _rigidbody.velocity = new Vector3(0f, 0f, 0f);
            RocketShipSecond.transform.rotation = Quaternion.identity;
        }
        else if (gameObject.name == "Rocket" && collision.collider.name == "obstacle 23")
        {
            RocketShipSecond.transform.position = position1;
            _rigidbody.angularVelocity = new Vector3(0f, 0f, 0f);
            _rigidbody.velocity = new Vector3(0f, 0f, 0f);
            RocketShipSecond.transform.rotation = Quaternion.identity;
        }
        else if (gameObject.name == "Rocket" && collision.collider.name == "target")
        {
            collision.gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
    }
}
