using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIMain : MonoBehaviour
{
    public TMP_InputField playerNameInput;

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void PlayerNameInput()
    {
        MainManager.Instance.playerName = playerNameInput.text;
    }
}
