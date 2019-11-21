using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float moveSpeed = 3f;
    Rigidbody2D body;
    Vector2 playerMovement;
    int walk = 0;
    public Sprite[] Sprite_Pic;
    public float wait = 0f;
    public float armSpeed = 0.5f;

    void Start () {
        body = GetComponent<Rigidbody2D>();
       
    }

    // Update is called once per frame
    void Update () {
        
        if (wait > armSpeed)
        {
            getSprite();    //update character
            wait = 0;
        }
        wait += Time.deltaTime;
        
        playerMovement.x = 0; //can only move up and down
        playerMovement.y = Input.GetAxis("Vertical");
	}

    void FixedUpdate()
    {
        if (transform.position.y <= -2.7f)
        {
            transform.position = new Vector2(transform.position.x, -2.7f);
        }
        else if (transform.position.y >= 2.7f)
        {
            transform.position = new Vector2(transform.position.x, 2.7f);
        }
        
        body.MovePosition(body.position + playerMovement * moveSpeed * Time.fixedDeltaTime);
    }

    void getSprite()
    {
        GetComponent<SpriteRenderer>().sprite = Sprite_Pic[walk];
        walk++;
        if (walk >= 2)
            walk = 0;
    }

    
    
}
