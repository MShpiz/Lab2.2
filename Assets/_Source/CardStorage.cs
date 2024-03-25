using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Card;
using System;

public class CardStorage 
{
    private List<CardAsset> cardAssets = new List<CardAsset>();
   public CardStorage()
    {

    }

    public IEnumerable GetCards() => cardAssets;

    public void Add(CardAsset asset)
    {
        if (asset == null)
        {
            throw new ArgumentNullException();
        }
        cardAssets.Add(asset);
    }

    public void Remove(CardAsset asset)
    {
        if (asset == null)
        {
            throw new ArgumentNullException();
        }
        cardAssets.Remove(asset);
    }

    public void Remove(int id)
    {
        cardAssets.RemoveAt(id);
    }
}
