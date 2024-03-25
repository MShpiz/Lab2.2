using UnityEngine;
using Card;

public class CardSpawner : MonoBehaviour
{
    private CardGame _cardGame;

    [SerializeField]
    private GameObject _cardPrefab;

    public void CreateCard(CardAsset cardAsset, int layout)
    {
        CardInstance cardInstance = new CardInstance(cardAsset);
        _cardGame.ChangeView(cardInstance, new CardView());
        CreateCardView(cardInstance);
        cardInstance.MoveToLayout(layout); // по условию не сказано что передавать
    }
    private void CreateCardView(CardInstance cardInstance)
    {
        GameObject card = Instantiate(_cardPrefab);
        CardView cardView = card.AddComponent<CardView>();
        cardView.init(cardInstance);
        _cardGame.ChangeView(cardInstance, cardView);

        
    }

    public void init(CardGame cardGame)
    {
        _cardGame = cardGame;
    }
}
