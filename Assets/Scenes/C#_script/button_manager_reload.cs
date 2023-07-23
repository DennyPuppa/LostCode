using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button_manager_reload : MonoBehaviour
{
   public void reStart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
  
}
