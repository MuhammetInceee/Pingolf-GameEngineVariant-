using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PinGolf/Coin/Coin Settings")]
public class CoinSettings : ScriptableObject
{
    public int coinCount;

    public float giftCounter = 150;
}
