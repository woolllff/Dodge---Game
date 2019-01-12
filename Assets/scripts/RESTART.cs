using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class RESTART : MonoBehaviour {
    public Text scoreText;
	public void restart()
    {
        SceneManager.LoadScene(0);
    }

    private void Start()
    {
        scoreText.text = "Score  " + PlayerPrefs.GetFloat("SCORE", 0).ToString("0");
    }
}
