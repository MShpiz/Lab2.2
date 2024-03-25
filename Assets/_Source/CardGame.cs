using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Card;

public class CardGame
{

    private CardStorage _storage;
    private CardSpawner _cardSpawner;
    private CardLoader _cardLoader = new();
    private CardRepository _cardRepository;


    public CardGame(CardStorage cardStorage, CardSpawner cardSpawner, CardRepository cardRepository)
    {
        _storage = cardStorage;
        _cardSpawner = cardSpawner;
        _cardSpawner.init(this);
        _cardRepository = cardRepository;
    }
    public void StartGame()
    {
        _cardSpawner.CreateCard(_cardLoader.LoadCard("sample"), 0);
    }

    public void ChangeView(CardInstance cardInstance, CardView cardView)
    {
        _cardRepository.Set(cardInstance, cardView);
    }

    public Dictionary<CardInstance, CardView> GetCardsInLayout(int layoutId)
    {
        Dictionary<CardInstance, CardView> cards = new();
        foreach (var item in _cardRepository.Repository)
        {
            if (item.Key.LayoutId == layoutId)
            {
                cards.Add(item.Key, item.Value);
            }
        }
        return cards;
    }


}

