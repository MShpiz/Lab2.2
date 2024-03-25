using UnityEngine;
using Card;

public class CardLoader : ICardLoader
{
    public CardAsset LoadCard(string name)
    {
        CardAsset card = Resources.Load<CardAsset>(name);
        return card;
    }

    public void UnloadCard(CardAsset cardAsset)
    {
        Resources.UnloadAsset(cardAsset);
    }
}
