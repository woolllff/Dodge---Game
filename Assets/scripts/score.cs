using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class score : MonoBehaviour {

    public Transform player;
    public Text scoretext;
    public Text highScore;
    
	// Use this for initialization
	void Start () {
        
	}

    void scoreCal()
    {
        float score = SceneManager.GetActiveScene().buildIndex * 1000 + player.transform.position.z;
        PlayerPrefs.SetFloat("SCORE", score);
    }
	// Update is called once per frame
	void Update ()
    {
        scoreCal();
        highScore.text = PlayerPrefs.GetFloat("highscore", 0).ToString("0");
        if (player.position.z< 0.5)
        {
            scoretext.text = "SCORE";
        }
        else
        {
            scoretext.text =  PlayerPrefs.GetFloat("SCORE",0).ToString("0");
        }
        
	}
}
