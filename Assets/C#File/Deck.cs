using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Deck : MonoBehaviour
{
    public class Card
    {
        public string CardName { get; }
        public string Description { get; }

        public Card(string cardName, string description)
        {
            CardName = cardName;
            Description = description;
        }
    }

    public class CustomDeck
    {
        private List<Card> cards;

        public CustomDeck()
        {
            InitializeDeck();
        }

        private void InitializeDeck()
        {
            cards = new List<Card>();

            for (int i = 0; i < 52; i++)
            {
                string cardName = $"Card {i + 1}";
                string description = $"This is card number {i + 1}";
                Card newCard = new Card(cardName, description);
                cards.Add(newCard);
            }

            ShuffleDeck();
        }

        public Card DrawCard()
        {
            if (cards.Count == 0)
            {
                Console.WriteLine("���� ī�尡 �����ϴ�!");
                return null;
            }

            Card drawnCard = cards[0];
            cards.RemoveAt(0);

            Console.WriteLine($"ī�带 �̾ҽ��ϴ�: {drawnCard.CardName}");

            return drawnCard;
        }

        public void AddCard(Card newCard)
        {
            cards.Add(newCard);
            Console.WriteLine($"���� ���ο� ī�尡 �߰��Ǿ����ϴ�: {newCard.CardName}");
        }

        private void ShuffleDeck()
        {
            int n = cards.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card value = cards[k];
                cards[k] = cards[n];
                cards[n] = value;
            }
        }
        public float GenerateRandomFloat(float min, float max)
        {
            return UnityEngine.Random.Range(min, max);
        }
    }
}
