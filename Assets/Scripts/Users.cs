using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Users : MonoBehaviour
{
    [SerializeField] private Text userName; // Text Mesh Pro ������Ʈ  

    public void SetInformation(string userNameText)
    {
        userName.text = userNameText;
    }
}
