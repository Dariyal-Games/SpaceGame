using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sample : MonoBehaviour {
    public float speed;
    public GameObject Planet;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 1f, 0) * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(1f, 0, 0) * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(-1f, 0, 0) * Time.deltaTime * speed);
        }
        AroundPlanet();
    }
    void AroundPlanet()
    {
        transform.RotateAround(Planet.transform.position, -Vector3.forward, speed * Time.deltaTime);
    }
}
