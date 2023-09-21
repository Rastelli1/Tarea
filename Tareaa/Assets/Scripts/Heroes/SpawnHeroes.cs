using UnityEngine;
using System;

namespace Heroes
{
  public class SpawnHeroes : MonoBehaviour{
        public int energiaDeCreacion = 100;
        [SerializeField] private HeroesFactory factoryHeroes;

        private void Update()
        {
            if (Input.GetKeyUp(KeyCode.Alpha1) && energiaDeCreacion>0) {
                factoryHeroes.Create(id: "Asesino");
                
                energiaDeCreacion = factoryHeroes.EnergiaConsumida(energiaDeCreacion, id: "Asesino");
                Debug.Log(energiaDeCreacion);
            }
            if (Input.GetKeyUp(KeyCode.Alpha2) && energiaDeCreacion > 0)
            {
                factoryHeroes.Create(id: "Tirador");
                energiaDeCreacion = factoryHeroes.EnergiaConsumida(energiaDeCreacion, id: "Tirador");

            }
            if (Input.GetKeyUp(KeyCode.Alpha3) && energiaDeCreacion > 0)
            {
                factoryHeroes.Create(id: "Mago");
                energiaDeCreacion = factoryHeroes.EnergiaConsumida(energiaDeCreacion, id: "Mago");
            }
            if (Input.GetKeyUp(KeyCode.Alpha4) && energiaDeCreacion > 0)
            {
                factoryHeroes.Create( id: "Luchador");
                energiaDeCreacion = factoryHeroes.EnergiaConsumida(energiaDeCreacion, id: "Luchador");
            }
            if (Input.GetKeyUp(KeyCode.Alpha5) && energiaDeCreacion > 0)
            {
                factoryHeroes.Create(id: "Guerrero");
                energiaDeCreacion=factoryHeroes.EnergiaConsumida(energiaDeCreacion, id: "Guerrero");
            }
        }
    }

}