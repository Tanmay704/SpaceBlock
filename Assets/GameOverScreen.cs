using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameOverScreen : MonoBehaviour
{
    public Text pointsText;
    public void Setup(int score)
    {
        gameObject.SetActive(true);
        pointsText.text = score.ToString() + " POINTS";
    }
    public void Restart() {
        Score.flag = 0;
        Score.i = 0;
        SceneManager.LoadScene("SampleScene");

    }


    public void Exit()
    {
         Application.Quit();
    }
}