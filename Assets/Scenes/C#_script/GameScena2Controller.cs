using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScena2Controller : MonoBehaviour
{
    GeneralGameController generalController;
    public Text item;
    public Text score;
    public Text clock;
    public bool playing;

    


    void Start()
    {
        //generalController = gameObject.GetComponent<GeneralGameController>();

        if (!generalController)
        {
            var temp = FindObjectOfType<GeneralGameController>();
            if (temp)
                generalController = temp;
        }
        generalController.itemCounts = 0;
        generalController.value = SessionData.GetScore();
        SessionData.SetLevelData();
        SessionData.SetNumberLevelObject(GameObject.FindGameObjectsWithTag("magicChest").Length);
    }

    void Update()
    {

        generalController.setTextPlaying(clock, score, item, playing);


    }
}
