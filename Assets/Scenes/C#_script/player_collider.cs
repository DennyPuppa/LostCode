using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_collider : MonoBehaviour

{
  
    GeneralGameController manager1;
    Health_controller foglio_2;


    private int nextSceneToLoad;
    public GameObject player;
    public Transform spawnpoint;
    public GameObject gameOver;

    public void Spawner()
    {
        player.transform.position = spawnpoint.position;
        foglio_2.health--;
    }


    public void dead()
    {
        if (foglio_2.health == 0)
        {
            SessionData.ResetLevelData();
            player.SetActive(false);
            gameOver.SetActive(true);
        }

    }

    private void Start()
    {
        if (!manager1)
        {
            var temp = FindObjectOfType<GeneralGameController>();
            if (temp)
                manager1 = temp;
        }
        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
        foglio_2 = gameObject.GetComponent<Health_controller>();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        //if (collision.tag == "damage")
        //{
        //    Spawner();
        //}

        //if (collision.tag == "end_map")
        //{
        //    Spawner();
        //}

        //if (collision.tag == "portal")
        //{
        //    SceneManager.LoadScene(nextSceneToLoad);
        //}
        //if (collision.tag == "treasure")
        //{
        //    manager1.itemCounts++;
        //    SessionData.AddItem();
        //}
        //if (collision.tag == "enemy")
        //{
        //    foglio_2.health--;
        //}
        switch (collision.tag)
        {
            case "damage":
                SoundManagerScript.PlaySounds("die");
                Spawner();
                break;

            case "end_map":
                SoundManagerScript.PlaySounds("die");
                Spawner();
                break;

            case "portal":
           
                SceneManager.LoadScene(nextSceneToLoad);
                break;

            case "treasure":
                manager1.itemCounts++;
                SessionData.AddItem();
                break;

            case "enemy":
                foglio_2.health--;
                break;

            case "finalPortal":
                if (SessionData.GetLevelNumbOfItem() == 19)
                    SceneManager.LoadScene("Final1");
                else
                    SceneManager.LoadScene("Final2");
                break;

            case "necessaryPortal":
                    SceneManager.LoadScene("menu_principale");
                break;

            default:
                break;
        }
    }

    private void Update()
    {
        dead();
    }
}
