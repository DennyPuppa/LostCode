using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GeneralGameController : MonoBehaviour
{
 
    public int value;
    private float Timer;
    public int itemCounts;


    public void setTextPlaying(Text clock, Text score, Text item,bool playing)
    {



        if (playing == true)
        {

            Timer += Time.deltaTime;
            int minutes = Mathf.FloorToInt(Timer / 60f);
            int seconds = Mathf.FloorToInt(Timer % 60f);
            int milliseconds = Mathf.FloorToInt((Timer * 100f) % 100f);
            clock.text = minutes.ToString("Tempo " + ":" + " " + "00") + ":" + seconds.ToString("00") + ":" + milliseconds.ToString("00");

        }

        item.text = "Oggetti: " + itemCounts.ToString() + "/" + SessionData.GetNumberLevelObject().ToString();
        score.text = "Score: " + value.ToString();
    }

}



