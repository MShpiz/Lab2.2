using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStarter : MonoBehaviour
{
    private CardGame _cardGame;
    void Awake()
    {
        CardStorage cardStorage = new();
        CardSpawner cardSpawner = GetComponentInChildren<CardSpawner>();
        CardRepository cardRepository = new();
        _cardGame = new CardGame(cardStorage, cardSpawner, cardRepository);

        _cardGame.StartGame();
    }

    
}
