using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class UI : MonoBehaviour
{
    [SerializeField] private Button openBtn; //사이드바 오픈버튼
    [SerializeField] private Image sideBar; //사이드바 오브젝트
    [SerializeField] private Button closeBtn; //사이드바 닫기버튼
    [SerializeField] private Users userPrefab; // 접속 유저마다 1개씩 생성 되는 Users Prefab 오브젝트  
    [SerializeField] private Transform contentTransform; // 인스턴스가 생성 될 부모 오브젝트 위치

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
