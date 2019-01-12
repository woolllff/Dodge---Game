using UnityEngine.SceneManagement;
using UnityEngine;

public class END : MonoBehaviour {

    public void quitGame()
    {
        Application.Quit();
    }

    public void mainMenu()
    {
        SceneManager.LoadScene(0);
    }


}
