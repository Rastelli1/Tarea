using System;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

namespace Heroes
{
    public class HeroesFactory: MonoBehaviour {


        [SerializeField] private Heroe[] heroes;
        private Dictionary<string, Heroe> heroesDictionary;

        private void Awake()
        {
            heroesDictionary = new Dictionary<string, Heroe>();

            foreach (var heroe in heroes)
            {
                
                    heroesDictionary.Add(heroe.Id, heroe);
                
                
            }
        }

        public Heroe Create (string id)
        {
            if (!heroesDictionary.TryGetValue(id, out var _heroe))
            {
                throw new Exception(message: $"no funciono");
            }
            
            return Instantiate(_heroe);
        }
        public int EnergiaConsumida(int energia , string id)
        {
            
            if(!heroesDictionary.TryGetValue(id, out var _heroe))
            {
                throw new Exception(message: $"no funciono");
            }
            int energiaActual= energia -_heroe.energia() ;
            return energiaActual;
        }
    }
}