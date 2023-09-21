using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Heroes
{
    public abstract class Heroe : MonoBehaviour{
        [SerializeField] private string id;
        [SerializeField] private int costeDeEnergia;
        public string Id => id;
        
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }
        public int energia()
        {
            return costeDeEnergia;
        }
}
}