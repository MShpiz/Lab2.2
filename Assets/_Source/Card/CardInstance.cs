using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Card
{

    public class CardInstance
    {
        private CardAsset _asset;
        public CardInstance(CardAsset asset)
        {
            _asset = asset;
        }

        public CardAsset Asset
        {
            get => _asset;
        }
        public void MoveToLayout(int layout, int cardPosition = -1)
        {

        }

        public int LayoutId = 0;
        public int LayoutPosition = 0;
    }

    
}
