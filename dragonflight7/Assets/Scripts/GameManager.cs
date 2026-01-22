using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Text scoreText;

    int score = 0;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void AddScore(int num)
    {
        score += num;
        scoreText.text = "Score: " + score;

        if (score > 1000)
        {
            SceneManager.LoadScene(1);
        }
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
