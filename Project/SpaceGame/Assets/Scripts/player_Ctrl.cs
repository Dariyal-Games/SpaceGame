using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_Ctrl : MonoBehaviour
{
    public Transform LThruster;
    public Transform RThruster;

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
        spaceShipControl();

    }

    void spaceShipControl()
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

    private void OnCollisionEnter2D(Collision2D gOver)
    {
        if (gOver.gameObject.tag == "GO")
        {
            SceneManager.LoadScene("GameOver");
        }
           
           
    }
}
