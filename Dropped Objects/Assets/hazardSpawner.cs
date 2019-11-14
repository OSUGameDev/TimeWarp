using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hazardSpawner : MonoBehaviour {
    public GameObject hazard;
    float randY;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;

    // GameObject.GetComponent(Movement).speed = 1;
    // Use this for initialization
    void Start () {
       // GameObject.GetComponent(Movement).moveSpeed = 1;
        
    }
	
	// Update is called once per frame
	void Update () {
		if(Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randY = Random.Range(-4f, 4f);
            whereToSpawn = new Vector2(transform.position.x, randY);
            Instantiate(hazard, whereToSpawn, Quaternion.identity);
        } 
        
    }

}
