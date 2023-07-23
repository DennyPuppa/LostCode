using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_system : MonoBehaviour
{
    [SerializeField]
    Transform player;

    [SerializeField]
    float agroRange;

    [SerializeField]
    float moveSpeed;

    Health_controller foglio_2;
    Rigidbody2D rb2d;

    
    public GameObject evil;
    ghost fantasma;




    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        foglio_2 = gameObject.GetComponent<Health_controller>();
        fantasma = gameObject.GetComponent<ghost>();

    }
    private void Update()
    {
        float distToPlayer = Vector2.Distance(transform.position,player.position);
        if(distToPlayer < agroRange)
        {
            ChasePlayer();
        }
        else
        {
            StopChasingPlayer();
        }

        
    }

     void ChasePlayer()
    {
        if(transform.position.x < player.position.x)
        {
            rb2d.velocity = new Vector2(moveSpeed, 0);
            //transform.localScale = new Vector2(-1, 1);
            GetComponent<SpriteRenderer>().flipX = true;

        }
        else
        {
            rb2d.velocity = new Vector2(-moveSpeed, 0);
            //transform.localScale = new Vector2(1, 1);
            GetComponent<SpriteRenderer>().flipX = false;
        }
    }
     void StopChasingPlayer()
    {
        rb2d.velocity = new Vector2(0,0);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.tag == "projectile")
        {
            
            evil.SetActive(false);
            fantasma.check();


        }
    }



}
