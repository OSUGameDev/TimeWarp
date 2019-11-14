using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomSpawner : MonoBehaviour {
    private int rand;
    public Sprite[] Sprite_Pic;
    Vector2 temp;
    private int randSize;
    public float rotateSpeed = .0f;
	// Use this for initialization
	void Start () {
        getRandSize();

        rand = Random.Range(0, Sprite_Pic.Length);
        GetComponent<SpriteRenderer>().sprite = Sprite_Pic[rand];
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void getRandSize ()
    {
        randSize = Random.Range(1, 4);
        temp = transform.localScale;
        temp.x = randSize;
        temp.y = randSize;
        transform.localScale = temp;
    }
}
