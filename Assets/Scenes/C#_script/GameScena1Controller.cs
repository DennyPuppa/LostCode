using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScena1Controller : MonoBehaviour
{
    GeneralGameController generalController;
    public Text item;
    public Text score;
    public Text clock;
    public bool playing;

    void Start()
    {
        if (!generalController)
        {
            var temp = FindObjectOfType<GeneralGameController>();
            if (temp)
                generalController = temp;
        }
        generalController.itemCounts = 0;
        generalController.value = 0;
        SessionData.ResetData();
        SessionData.SetLevelData();
        SessionData.SetNumberLevelObject(GameObject.FindGameObjectsWithTag("magicChest").Length);
    }

    void Update()
    {
        
        generalController.setTextPlaying(clock, score, item, playing);
       
        
    }

}
