using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class SceneLoader : MonoBehaviour
{
    private ICardLoader _cardLoader;

    [Inject]
    public void Init(ICardLoader cardLoader)
    {
        _cardLoader = cardLoader;
    }
}
