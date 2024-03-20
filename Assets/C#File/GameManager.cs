using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Deck deck;
    void Start()
    {
        InitializeDeck_();
    }

    // 덱 초기화 메서드
    void InitializeDeck_()
    {
        if (deck == null)
        {
            Debug.LogError("덱이 할당되지 않았습니다!");
            return;
        }

        Debug.Log("덱이 초기화되었습니다.");
    }

    // Update() 메서드는 필요에 따라 추가하여 사용
    void Update()
    {
        // 필요한 경우 게임 로직 업데이트
    }
}
