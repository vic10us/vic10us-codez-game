using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public GameObject completeLevelUI;

    public void EndGame()
    {
        if (gameHasEnded) return;
        Debug.Log("GAME OVER");
        gameHasEnded = true;
        Restart();
    }

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
