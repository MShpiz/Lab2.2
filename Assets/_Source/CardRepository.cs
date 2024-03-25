using System.Collections.Generic;
using Card;

public class CardRepository
{
    private Dictionary<CardInstance, CardView> _cardsRepository = new();

    public CardView Get(CardInstance cardInstance)
    {
        return _cardsRepository[cardInstance];
    }

    public Dictionary<CardInstance, CardView> Repository
    {
        get
        {
            return _cardsRepository;
        }
    }

    public void Set(CardInstance instance, CardView view)
    {
        if (_cardsRepository.ContainsKey(instance))
        {
            _cardsRepository[instance] = view;
        }
        else
        {
            _cardsRepository.Add(instance, view);
        }
    }
}
