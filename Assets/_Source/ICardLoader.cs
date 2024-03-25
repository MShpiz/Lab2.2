using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Card;
public interface ICardLoader 
{
    public CardAsset LoadCard(string name);

    public void UnloadCard(CardAsset cardAsset);
}
