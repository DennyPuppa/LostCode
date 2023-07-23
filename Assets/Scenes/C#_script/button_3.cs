using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button_3 : MonoBehaviour
{
    public void reDoing()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
