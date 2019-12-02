using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backScroll : MonoBehaviour {
    public float speed;
    public Renderer bgRend;
   
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bgRend.material.mainTextureOffset += new Vector2(speed * Time.deltaTime, 0f);
    }


}
