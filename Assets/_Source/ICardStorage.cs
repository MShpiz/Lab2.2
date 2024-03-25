using System.Collections;
using Card;


public interface ICardStorage
{
    public IEnumerable GetCards();

    public void Add(CardAsset asset);
    
    public void Remove(CardAsset asset);

    public void Remove(int id);
}
