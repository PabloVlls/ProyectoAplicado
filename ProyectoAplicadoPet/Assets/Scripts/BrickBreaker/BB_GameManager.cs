using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BB_GameManager : MonoBehaviour
{
    public int level = 1;
    public int score = 0;
    public int lives = 3;

    public BB_Ball ball {  get; private set; }
    public BB_PaddleMov paddle { get; private set; }

    public BB_Brick[] bricks { get; private set; }

    

    private void Awake()  
    {
        DontDestroyOnLoad(this.gameObject);

        SceneManager.sceneLoaded += OnLevelLoaded;
    }

    public void Start()
    {
       // NewGame();
    }


    public void NewGame()
    {
        this.score = 0;
        this.lives = 3;
        LoadLevel(1);
    }

    


    private void LoadLevel(int level)
    {
        this.level = level;

        if(level > 4)
        {
            SceneManager.LoadScene("BB_WinScreen");
        }
        else
        {
            SceneManager.LoadScene("Level " + level);
        }

        



    }

    private void OnLevelLoaded(Scene scene, LoadSceneMode mode)
    {
        this.ball = FindObjectOfType<BB_Ball>();
        this.paddle = FindObjectOfType<BB_PaddleMov>();
        this.bricks = FindObjectsOfType<BB_Brick>(); 
    }

    public void LoseLive()
    {
        this.lives--;

        if (this.lives > 0)
        {
            ResetLevel();
        }
        else
        {
            GameOver();
        }
    }

    private void ResetLevel()
    {
        
        this.ball.ResetBall();
        this.paddle.ResetPaddle();
    }

    private void GameOver()
    {
        SceneManager.LoadScene("BB_GameOver");
    }

    public void Hit(BB_Brick brick)
    {
        this.score += brick.points;

        if (ClearedBoard())
        {
            LoadLevel(this.level + 1);
            if (lives >= 0 || lives <= 4)
            {
                lives++;
            }
        }

    }

    private bool ClearedBoard()
    {
        for (int i = 0; i< this.bricks.Length; i++)
        {
            if (this.bricks[i].gameObject.activeInHierarchy && !this.bricks[i].unbreakeble)
            {
                return false;
            }       
        }

        return true;
    }

}
