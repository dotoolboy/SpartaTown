using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InputName : MonoBehaviour
{
    public InputField nameInputField;

    public void StartGame()
    {
        // 입력한 이름을 가져옴
        string playerName = nameInputField.text;

        // 이름의 길이가 2에서 10 사이인지 확인
        if (playerName.Length >= 2 && playerName.Length <= 10)
        {
            // 조건에 맞으면 PlayerPrefs에 저장하고 MainScene으로 전환
            PlayerPrefs.SetString("PlayerName", playerName);
            SceneManager.LoadScene("MainScene");
        }
    }
}