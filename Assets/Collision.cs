using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public GameOverScreen GameOverScreen;
    public void GameOver()
    {
        GameOverScreen.Setup(Score.i);
    }

    void OnCollisionEnter()
    {
        Score.flag = 1;
     
        GameOver();
        Destroy(gameObject);
        //  FindObjectOfType<GameManager>().EndGame();

    }
}
