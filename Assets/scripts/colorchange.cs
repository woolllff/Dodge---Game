
using UnityEngine;

public class colorchange : MonoBehaviour {

    public Material playerMaterial;
    public GameObject colorselect;
    public GameObject maincamera;
    public GameObject startgame;
    public GameObject scoreCanvas;
    private Color rgb ;

    // red (255,0,0)    blue (0,0,255)      green (0,255,0)     yellow (255,255,0)      purple(100,0,255)      skyblue(0,255,255)
    private void Start()
    {
        rgb = playerMaterial.color;
    }
    public void red()
    {
        rgb.r = 255;
        rgb.g = 0;
        rgb.b = 0;
        applyColor();
    }
    public void blue()
    {
        rgb.r = 0;
        rgb.g = 0;
        rgb.b = 255;
        applyColor();
    }
    public void green()
    {
        rgb.r = 0;
        rgb.g = 255;
        rgb.b = 0;
        applyColor();
    }
    public void yellow()
    {
        rgb.r = 255;
        rgb.g = 255;
        rgb.b = 0;
        applyColor();
    }
    public void purple()
    {
        rgb.r = 100;
        rgb.g = 0;
        rgb.b = 255;
        applyColor();
    }
    public void skyblue()
    {
        rgb.r = 0;
        rgb.g = 255;
        rgb.b = 255;
        applyColor();
    }
    public void applyColor()
    {
        setColor();
        rgb.a = 1;
        playerMaterial.color = rgb;
    }
    private void setColor()
    {
        PlayerPrefs.SetFloat("COLOR.R", rgb.r);
        PlayerPrefs.SetFloat("COLOR.G", rgb.g);
        PlayerPrefs.SetFloat("COLOR.B", rgb.b);
    }

    public void back()
    {
        maincamera.transform.Rotate(0, 180, 0);
        colorselect.SetActive(false);
        startgame.SetActive(true);
        scoreCanvas.SetActive(true);

    }
    public void resetHighscore()
    {
        PlayerPrefs.SetFloat("highscore", 0);
    }

}
