using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private List<Card> deck;

    void Start()
    {
        deck = new List<Card>();
    }

    public void AddCardToDeck(Card newCard)
    {
        deck.Add(newCard);
    }
}
