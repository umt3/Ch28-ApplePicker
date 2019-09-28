using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    static public int score = 1000;

    void Awake()
    {
        //if playerPrefs highScore

        if (PlayerPrefs.HasKey("High Score"))
        {
            score = PlayerPrefs.GetInt("High Score");
        }


        //assign the high score to high score

        PlayerPrefs.SetInt("High Score", score);

    }

    void Update()
    {
        Text gt = this.GetComponent<Text>();
        gt.text = "High Score: " + score;

        //update the playerprefs highscore

        if (score > PlayerPrefs.GetInt("High Score"))
        {

            PlayerPrefs.SetInt("High Score", score);
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }


}
