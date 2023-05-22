using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comportamientoPelota : MonoBehaviour
{
    public Transform initialPosition;
    public ControlJuego controlador;

    public void RestartPosition()
    {
        transform.position = initialPosition.position;
    }

    public void OnCollisionEnter(Collision collision){
        if (collision.gameObject.name == "DeathWall")
        {
            transform.position = initialPosition.position;
            controlador.controladorNiveles[controlador.indiceNivel].intentos += 1;

            if (controlador.indiceNivel > 0)
            {
                var newLvl = controlador.indiceNivel -= 1;
                controlador.controladorNiveles[newLvl].intentos += 1;
                controlador.muestraNiveles[newLvl + 1].SetActive(false);
                controlador.muestraNiveles[newLvl].SetActive(true);
            }
        }
    }
}
