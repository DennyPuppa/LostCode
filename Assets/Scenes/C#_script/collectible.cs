﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectible : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "player")
        {
            SoundManagerScript.PlaySounds("collectible");
            gameObject.SetActive(false);
        }
        
    }
}
