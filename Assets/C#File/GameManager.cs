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

    // �� �ʱ�ȭ �޼���
    void InitializeDeck_()
    {
        if (deck == null)
        {
            Debug.LogError("���� �Ҵ���� �ʾҽ��ϴ�!");
            return;
        }

        Debug.Log("���� �ʱ�ȭ�Ǿ����ϴ�.");
    }

    // Update() �޼���� �ʿ信 ���� �߰��Ͽ� ���
    void Update()
    {
        // �ʿ��� ��� ���� ���� ������Ʈ
    }
}
