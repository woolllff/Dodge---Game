
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextlevel : MonoBehaviour {

	public void loadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
