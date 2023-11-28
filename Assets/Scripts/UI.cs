using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class UI : MonoBehaviour
{
    [SerializeField] private Button openBtn; //���̵�� ���¹�ư
    [SerializeField] private Image sideBar; //���̵�� ������Ʈ
    [SerializeField] private Button closeBtn; //���̵�� �ݱ��ư
    [SerializeField] private Users userPrefab; // ���� �������� 1���� ���� �Ǵ� Users Prefab ������Ʈ  
    [SerializeField] private Transform contentTransform; // �ν��Ͻ��� ���� �� �θ� ������Ʈ ��ġ

    private void Awake()
    {
        openBtn.onClick.AddListener(OpenSideBar);
        closeBtn.onClick.AddListener(CloseSideBar);
        sideBar.gameObject.SetActive(false);
    }

    private void CloseSideBar()
    {
        sideBar.gameObject.SetActive(false);
    }

    private void OpenSideBar()
    {
        sideBar.gameObject.SetActive(true);

    }


}
