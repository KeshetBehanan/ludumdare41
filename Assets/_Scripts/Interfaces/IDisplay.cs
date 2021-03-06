﻿using UnityEngine;

public enum CardType { Tower, Enemy, Magic };

public interface IDisplay
{
    CardType type { get; }
    void SelectCard();
    bool TryPlayCard(Vector2 pos);
    int GetCardCost();
    Sprite GetCardVisual();

    void DestroyCard();
}
