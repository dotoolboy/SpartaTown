using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BringName : MonoBehaviour
{

    public Text playerNameText;
    // Start is called before the first frame update
    void Start()
    {
        // PlayerPrefs���� ����� PlayerName�� �޾ƿ�
        string playerName = PlayerPrefs.GetString("PlayerName", "Player");
        playerNameText.text = playerName;
    }

    
}
