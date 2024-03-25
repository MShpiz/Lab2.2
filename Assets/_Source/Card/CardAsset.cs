using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Card
{
    [CreateAssetMenu(menuName ="SO/new Card Asset", fileName = "CardAsset")]
    public class CardAsset : ScriptableObject
    {
        [field: SerializeField]
        public string _name;       // назавние карты.
        [field: SerializeField]
        public Sprite _image;      // изображение карты, полагаю что это спрайт, тк иного не сказано.
        [field: SerializeField]
        public Color _color;       // цвет карты, пусть будет Unity.Color, коментариев на это счёт тоже нет.
    }
}

