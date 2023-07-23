using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chest : MonoBehaviour
{

    public GameObject box;
    //public GameObject[] item;
    //public Transform SpawnPoint;
    public GameObject collezionabile;
    public GameObject chest_open;
    public GameObject father;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "player")
        {
            collezionabile.SetActive(true);
            chest_open.SetActive(true);
            box.SetActive(false);
            Destroy(father.GetComponent<BoxCollider2D>());
        }
    }
}
