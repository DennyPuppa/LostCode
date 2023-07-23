using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class portalcollider : MonoBehaviour
{
    public GameObject portal;

    private void OnTriggerEnter2D(Collider2D portal)
    {
        SceneManager.LoadScene("level_2");
    }
}
