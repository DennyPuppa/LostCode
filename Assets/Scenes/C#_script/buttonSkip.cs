using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonSkip : MonoBehaviour
{
    private int nextScene;
    public void Start()
    {
        nextScene = SceneManager.GetActiveScene().buildIndex + 1;
    }

    public void Skip()
    {
      SceneManager.LoadScene(nextScene);
    }
}
