using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int i;
    public Transform player;
    public Text scoreText;

    // Update is called once per frame
   public void Update()
    {

        if (!PauseMenue.GameIsPaused)
        {
            scoreText.text = i.ToString("0");
            i++;
        }
    }
}
