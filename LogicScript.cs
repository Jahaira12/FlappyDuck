using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
   public int playerScore = 0;
   public Text scoreText;
    [ContextMenu("Increase Score")]
    public void UpdateScore()
    {
        playerScore = playerScore + 1;
        scoreText.text = playerScore.ToString();

    }
}
