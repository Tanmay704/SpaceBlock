using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static int i;
    public static int flag = 0;
    public Transform player;
    public Text scoreText;

    // Update is called once per frame
   public void Update()
    {
        if(flag == 1)
        { gameObject.SetActive(false); }
        if (!PauseMenue.GameIsPaused && flag != 1)
        {
            scoreText.text = i.ToString("0");
            i++;
            
        }
    }
}
