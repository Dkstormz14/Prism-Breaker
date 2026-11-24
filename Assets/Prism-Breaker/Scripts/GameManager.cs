using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int level = 1;
    public int score = 0;
    public int lives = 3;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject); 
    }

    private void Start()
    {
        NewGame();
    }

    private void NewGame()
    {
        this.score = 0;
        this.lives = 3;

        LoadLevel(1);
    }

    public void LoadLevel(int level)
    {
        this.level = level;
        // Load the level scene here
        SceneManager.LoadScene("Level" + level);
        // Loads the next level scene based on the level number
    }

}
