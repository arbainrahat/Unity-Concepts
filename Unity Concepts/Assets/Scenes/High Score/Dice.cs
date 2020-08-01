using UnityEngine.UI;
using UnityEngine;

public class Dice : MonoBehaviour
{
    public Text score;
    public Text highscore;
    private void Start()
    {
       highscore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }
    public void RollDice()
    {
        int number = Random.Range(1,7);
        score.text = number.ToString();

        if(number> PlayerPrefs.GetInt("HighScore",0))
        {
            PlayerPrefs.SetInt("HighScore", number);
            highscore.text = number.ToString();
        }
    }

    public void Reset()
    {
        PlayerPrefs.DeleteAll();
        highscore.text = "0";
    }

}
