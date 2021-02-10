using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyList<K, V>
    {
        K[] _key;
        V[] _value;

        public MyList()
        {
            _value = new V[0];
            _key = new K[0];
        }

        public void Add(K key, V value) {

            K[] tempKeyArray = _key;
            V[] tempValueArray = _value;
            _value = new V[_value.Length + 1];
            _key = new K[_key.Length + 1];

            for (int i = 0; i < tempKeyArray.Length; i++)
            {
                _key[i] = tempKeyArray[i];
            }

            _key[_key.Length - 1] = key;

            for (int i = 0; i < tempValueArray.Length; i++)
            {
                _value[i] = tempValueArray[i];
            }

            _value[_value.Length - 1] = value;

        }           //*** ADD  ***
        public int Length
        {
            get { return _key.Length; }

        }
        public int Length2
        {
            get { return _value.Length; }
        }
        public V[] Values
        {
            get { return _value; }
        }
    }
}
