
using UnityEngine;

public class startgame : MonoBehaviour {

    public GameObject player;
    public GameObject startGame;
    public GameObject maincamera;
    public GameObject colorselect;
    public GameObject scoreCanvas;
    public Material playerMaterial;
    private Color rgb;

    private void Start()
    {
        rgb.r = PlayerPrefs.GetFloat("COLOR.R", 255);
        rgb.g = PlayerPrefs.GetFloat("COLOR.G", 0);
        rgb.b = PlayerPrefs.GetFloat("COLOR.B", 0);
        rgb.a = 1;
        playerMaterial.color = rgb;
    }
    public void PlayGame()
    {
        scoreCanvas.SetActive(true);
        player.SetActive(true);
        startGame.SetActive(false);
    }
    public void enterSettings()
    {
        scoreCanvas.SetActive(false);
        maincamera.transform.Rotate(0, 180, 0);
        startGame.SetActive(false);
        colorselect.SetActive(true);
    }
}
