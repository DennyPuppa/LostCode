using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip  fireSound, jumpSound, explosionSound,playerDieSounds,collectibleSounds;
    static AudioSource audioSrc;

    void Start()
    {
        collectibleSounds = Resources.Load<AudioClip>("collectible");
        playerDieSounds = Resources.Load<AudioClip>("die");
        fireSound = Resources.Load<AudioClip>("fire");
        jumpSound = Resources.Load<AudioClip>("jump");
        explosionSound = Resources.Load<AudioClip>("explosion");


        audioSrc = GetComponent<AudioSource>();
    }

    public static void PlaySounds(string clip)
    {
        switch (clip)
        {
            case "fire":

                audioSrc.PlayOneShot(fireSound);
                    
                break;

            case "jump":

                audioSrc.PlayOneShot(jumpSound);

                break;

         
            case "explosion":

                audioSrc.PlayOneShot(explosionSound);

                break;

            case "die":

                audioSrc.PlayOneShot(playerDieSounds);

                break;

            case "collectible":

                audioSrc.PlayOneShot(collectibleSounds);

                break;
        }
    }

}
