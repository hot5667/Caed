using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Deck deck;
    // Start is called before the first frame update
    void Start()
    {
        deck.InitializeDeck();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
