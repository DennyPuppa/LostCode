using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ghost : MonoBehaviour
{
    GeneralGameController manager1;
    public int valor = 100;
    public GameObject phantom;

    public void Start()
    {
        if (!manager1)
        {
            var temp = FindObjectOfType<GeneralGameController>();
            if (temp)
                manager1 = temp;
        }
       
    }

    public void check()
    {
        if (!phantom.activeInHierarchy)
        {
            manager1.value += valor;
            SessionData.AddScore(valor);
        }
    }



}
