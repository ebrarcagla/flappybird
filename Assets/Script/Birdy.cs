using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birdy : MonoBehaviour
{
    public bool isDead;
    public float velocity = 1f;
    public Rigidbody2D rb2D;
    public GameManager managerGame;
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Dedector")
        {
            managerGame.UpdateScore();
        } //eğer tagı bu ise (detector)

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DeathArea")
        {
            isDead = true;
            Time.timeScale = 0;
            managerGame.deathscreen.SetActive(true);
            managerGame.UpdateScoreLast();
        }
    }
}

