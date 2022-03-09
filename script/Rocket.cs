using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{

    public float speed = 150 ;
    // Start is called before the first fram
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // left or A: h = -1
        // Right or D : h = 1
       float h = Input.GetAxisRaw("Horizontal");

       GetComponent<Rigidbody2D>().velocity = Vector2.right * h * speed ;
        

    }
}