using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Card
{
    [CreateAssetMenu(menuName ="SO/new Card Asset", fileName = "CardAsset")]
    public class CardAsset : ScriptableObject
    {
        [field: SerializeField]
        public string _name;       // �������� �����.
        [field: SerializeField]
        public Sprite _image;      // ����������� �����, ������� ��� ��� ������, �� ����� �� �������.
        [field: SerializeField]
        public Color _color;       // ���� �����, ����� ����� Unity.Color, ����������� �� ��� ���� ���� ���.
    }
}

