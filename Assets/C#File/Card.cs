using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Custom/Card")]

public class Card : ScriptableObject
{
    public string cardName;
    public string description;
}
