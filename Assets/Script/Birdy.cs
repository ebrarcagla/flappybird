using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birdy : MonoBehaviour
{
    public bool isDead;
    public float velocity = 1f;
    public Rigidbody2D rb2D;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        //tıklamayı al
        if(Input.GetMouseButtonDown(0))
        {
            //Havada kuşu sıçrat
            rb2D.velocity = Vector2.up * velocity;
        }
    }
}
