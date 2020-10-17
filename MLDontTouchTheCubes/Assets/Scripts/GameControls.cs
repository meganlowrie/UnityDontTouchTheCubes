using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControls: MonoBehaviour
{
//timer text object
private Text timerText;
//timer counter for adding score
private int timerCount;

    // Start is called before the first frame update
    void Start()
    {
        //game is at a playing state
        Time.timeScale = 1f;

        //executing a courtine
        StartCoroutine(CountTime());

        //timer text equals finding the score object and
        //using the text component
        timerText = GameObject.Find("Score").GetComponent<Text>();
    }

    IEnumerator CountTime(){
        //after 1 second 1 point is added to score
        // and will repeat the function
        yield return new WaitForSeconds(1f);
        timerCount++;
        timerText.text = "Score: " + timerCount;
        StartCoroutine(CountTime());
    }

    
}
