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
        // �Է��� �̸��� ������
        string playerName = nameInputField.text;

        // �̸��� ���̰� 2���� 10 �������� Ȯ��
        if (playerName.Length >= 2 && playerName.Length <= 10)
        {
            // ���ǿ� ������ PlayerPrefs�� �����ϰ� MainScene���� ��ȯ
            PlayerPrefs.SetString("PlayerName", playerName);
            SceneManager.LoadScene("MainScene");
        }
    }
}