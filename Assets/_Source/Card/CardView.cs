using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Card
{

    public class CardView : MonoBehaviour
    {
        private CardInstance _instance;
        public void init(CardInstance instance)
        {
            _instance = instance;
        }
        public void Rotate(bool up)
        {
            GetComponent<SpriteRenderer>().enabled = up;
        }
    }
}
