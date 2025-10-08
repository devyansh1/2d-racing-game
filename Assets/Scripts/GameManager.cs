using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverScreen;
    private static GameManager instance;
    public static GameManager Instance { get { return instance; } }
    public bool gameOver = false;
    public UnityEvent onGameOver;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {

    }
    public void GameOver()
    {
        gameOver = true;
        Invoke("GameOverDelayed", 1.3f);
        onGameOver.Invoke();
    }
    public void GameOverDelayed()
    {
        gameOverScreen.SetActive(true);

        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}


//using UnityEngine;
//using UnityEngine.SceneManagement;
//using UnityEngine.Events;
//using UnityEngine.UI;

//public class GameManager : MonoBehaviour
//{
//    public GameObject gameOverScreen;
//    private static GameManager instance;
//    public static GameManager Instance { get { return instance; } }
//    public bool gameOver = false;

//    private void Awake()
//    {
//        if (instance == null)
//        {
//            instance = this;
//        }
//        else
//        {
//            Destroy(gameObject);
//        }
//    }

//    void Start()
//    {

//    }
//    public void GameOver()
//    {
//        gameOver = true;
//        Invoke("GameOverDelayed", 1.3f);
//    }
//    public void GameOverDelayed()
//    {
//        gameOverScreen.SetActive(true);

//        Time.timeScale = 0f;
//    }

//    public void RestartGame()
//    {
//        Time.timeScale = 1f;

//        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
//    }
//}
