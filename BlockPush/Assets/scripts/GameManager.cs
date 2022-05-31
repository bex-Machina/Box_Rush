
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    float delay = 2f;
    public GameObject LevelCompleted;
    public void CompleteLevel()
    {
        LevelCompleted.SetActive(true);
    }

    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("Restart", delay);
        }

    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
