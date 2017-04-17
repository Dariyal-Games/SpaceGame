using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawningPickup : MonoBehaviour {

    public GameObject Pickups;
    private float SpawnRate = 5f;
    private float NextSpawnTime = 5f;

	// Use this for initialization
	void Start () {

        Invoke("PickupSpawner", SpawnRate);

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void PickupSpawner()
    {

        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0,0));
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(.5f,.5f));

        GameObject pickupObj = (GameObject)Instantiate(Pickups);
        pickupObj.transform.position = new Vector2(Random.Range(min.x, max.x), max.y);

        SpawnTime();

    }

    void SpawnTime()
    {

        float spawnInNSec;

        if (SpawnRate > 1f)
        {
            spawnInNSec = Random.Range(1f, SpawnRate);
        }
        else

        spawnInNSec = 1f;
        Invoke("PickupSpawner", spawnInNSec);
    }


}
