using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TutorialPannelController : MonoBehaviour
{
    public GameObject tutorialPanel;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("player"))
        {
            Time.timeScale = 0;
            tutorialPanel.SetActive(true);
            Destroy(this.GetComponent<BoxCollider2D>());

        }

    }

    public void Riprendi()
    {
        tutorialPanel.SetActive(false);
        Time.timeScale = 1f;
    }
}
