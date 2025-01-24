using TMPro;
using UnityEngine;

public class UIGame : MonoBehaviour
{
    public TextMeshProUGUI playerText;
    public TextMeshProUGUI recordText;

    void Start()
    {
        playerText.text = "Player: " + MainManager.Instance.playerName;
        recordText.text = "Record: " + MainManager.Instance.highScore + " by " + MainManager.Instance.highScorePlayer;
    }
}
