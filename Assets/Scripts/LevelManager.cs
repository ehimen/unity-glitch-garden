using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

    public float loadNextDelay = 0f;

    void Start()
    {
        if (loadNextDelay > 0)
        {
            Invoke("LoadNextLevel", loadNextDelay);
        }
    }


	public void QuitRequest(){
		Application.Quit ();
	}

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadLevel(string name)
    {
        SceneManager.LoadScene(name);
    }

}
