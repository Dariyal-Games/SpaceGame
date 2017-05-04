using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_Ctrl : MonoBehaviour
{
    public Transform LThruster;
    public Transform RThruster;
    public GameObject Planet;


    public float Speed;
    public float Force = 30;

    private Vector3 leftThrusterDirection;
    private Vector3 rightThrusterDirection;
    private Vector3 playerMove;


    Rigidbody2D rb;


    // Use this for initialization
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();



        leftThrusterDirection = (transform.position - LThruster.position).normalized;
        rightThrusterDirection = (transform.position - RThruster.position).normalized;
        Debug.Log("LeftThrustDir:" + leftThrusterDirection);
        Debug.Log("RightThrustDir:" + rightThrusterDirection);

    }

    // Update is called once per frame
    void Update()
    {
        SpaceShipControl();
        AroundPlanet();
    }

    void SpaceShipControl()
    {
        if (Input.GetMouseButton(0))
        {

            if (Input.mousePosition.x < Screen.width / 2)
            {
                rb.AddForce(rightThrusterDirection * Force);
            }

            if (Input.mousePosition.x > Screen.width / 2)
            {
                rb.AddForce(leftThrusterDirection * Force);
            }
        }
    }

    void AroundPlanet()
    {
        transform.RotateAround(Planet.transform.position, -Vector3.forward, Speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D gOver)
    {
        if (gOver.gameObject.tag == "GO")
        {
            SceneManager.LoadScene("GameOver");
        }

    }

    private void OnTriggerEnter2D(Collider2D gather)
    {
        if (gather.gameObject.tag == "Fuel")
        {
            Destroy(gather.gameObject);
            Debug.Log("Collected");
        }
    }
}
