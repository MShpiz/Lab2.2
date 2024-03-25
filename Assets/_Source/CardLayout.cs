using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Card;

public class CardLayout : MonoBehaviour
{
    private CardGame _cardGame;
    public bool FaceUp;
    public int LayoutId;
    public Vector2 Offset;

    private void Update()
    {
        Dictionary<CardInstance, CardView> repository = _cardGame.GetCardsInLayout(LayoutId);
        foreach (var item in repository)
        {
            item.Value.Rotate(FaceUp);
            item.Value.transform.position = new Vector2(item.Value.transform.position.x, item.Value.transform.position.y);
        }
    }
}
