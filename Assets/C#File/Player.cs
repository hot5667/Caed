using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Deck deck;

    public void AddCardToDeck(Card newCard)
    {
        deck.AddCard(newCard);
    }
}
