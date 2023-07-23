using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class Health_controller : MonoBehaviour
{
    public int health;
    public int numbOfHearts;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;


    private void Update()
    {

        if(health > numbOfHearts)
        {
            health = numbOfHearts;
        }

        for(int i = 0; i < hearts.Length; i++)
        {
            if(i < health)
            {
                hearts[i].sprite = fullHeart;
            } else
            {
                hearts[i].sprite = emptyHeart;
            }
           if(i < numbOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }
}
