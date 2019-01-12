using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class gameManager : MonoBehaviour{
    private GameObject setObs;
    private Vector3 disBtwObs;
    private Vector3 pos;
    bool game=true;
    public GameObject completeLevelUI;
    public GameObject player;
    public GameObject obs1;
    public GameObject obs2;
    public GameObject obs3;
    public GameObject obs4;
    public GameObject obs5;
    public GameObject obs6;
    public GameObject obs7;
    public GameObject obs8;
    public GameObject obs9;
    public GameObject obs10;


    private void Start()
    {
        disBtwObs.x = 0;
        disBtwObs.y = 2;
        disBtwObs.z = 50;
    }

    public void completeLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if (game)
        {
            
            float score=PlayerPrefs.GetFloat("SCORE", 0);
            if (PlayerPrefs.GetFloat("highscore", 0) <= score)
            {
                PlayerPrefs.SetFloat("highscore", score);
            }
            Debug.Log("Game over");
            game = false;
            Invoke("Restart", 1);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(4);
    }

    public void activateNewObs()
    {
       
       
        int a=Random.Range(2,11);
        switch (a)
        {
            case 2:
                setObs = obs2;
                break;
            case 3:
                setObs = obs3;
                break;
            case 4:
                setObs = obs4;
                break;
            case 5:
                setObs = obs5;
                break;
            case 6:
                setObs = obs6;
                break;
            case 7:
                setObs = obs7;
                break;
            case 8:
                setObs = obs8;
                break;
            case 9:
                setObs = obs9;
                break;
            case 10:
                setObs = obs10;
                break;


           
        }
        setObs.SetActive(true);
        setObs.transform.position = player.transform.position + disBtwObs;
        pos = setObs.transform.position;
        pos.x = 0;
        setObs.transform.position = pos;

    }

}
