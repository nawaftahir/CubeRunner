using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject levelCompleteUI;
    public AudioSource sfx;
    public AudioClip loseClip;
    public AudioClip winClip;
    public AudioClip coinClip;

    public int coins = 0;
    bool gameHasEnded = false;

    void Awake()
    {
        instance = this;
    }

    public void AddCoin()
    {
        coins++;
        sfx.PlayOneShot(coinClip);
    }

    public void EndGame()
    {
        if (gameHasEnded) return;
        gameHasEnded = true;

        sfx.PlayOneShot(loseClip);
        Invoke("Restart", 1f);
    }

    public void CompleteLevel()
    {
        if (gameHasEnded) return;
        gameHasEnded = true;

        levelCompleteUI.SetActive(true);
        sfx.PlayOneShot(winClip);
        Invoke("NextLevel", 2f);
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void NextLevel()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
            SceneManager.LoadScene(1);
        else
            SceneManager.LoadScene(0);
    }
}
