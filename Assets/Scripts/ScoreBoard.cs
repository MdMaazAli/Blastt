using UnityEngine;
using TMPro;

public class ScoreBoard : MonoBehaviour
{

    [SerializeField] TMP_Text scoreBoardText;
    int score=0;


    public void increaseScore(int points){
        score+=points;
        scoreBoardText.text=score.ToString();
        getScore();
    }
    public int getScore(){
        return score;
    }

}
