using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinGame : MonoBehaviour
{
    public ControlJuego Controlador;
    public comportamientoPelota Pelota;
    
    public void OnTriggerEnter (Collider other){

        if (other.tag == "Pelota")
        {

            if (Controlador.indiceNivel == 2)
            {
                Controlador.ControlIntentos();

            }
            else
            {
                var newLvl = Controlador.indiceNivel += 1;
                Controlador.muestraNiveles[newLvl - 1].SetActive(false);
                Controlador.muestraNiveles[newLvl].SetActive(true);
                other.transform.position = Pelota.initialPosition.position;
            }



            }
    }
}
