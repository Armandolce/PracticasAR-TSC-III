using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlJuego : MonoBehaviour
{
    public GameObject []muestraNiveles;
    public ControlNivel []niveles;
    public int intentosTotal;
    public int indiceNivel;
    // Start is called before the first frame update
    void Start()
    {
        foreach (var levels in niveles)
        {
            levels.gameObject.SetActive(false);
        }
        muestraNiveles[0].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        //muestraNivel[indiceNivel].setActive();
        //controlIntentos();   
    }
    public void controlIntentos(){
        intentosTotal += niveles[indiceNivel].intentos; 
    }
    // public void controlNivel(){
    //     for (int i = 0; i < muestraNiveles.Length; i++)
    //     {
    //         muestraNiveles[i].SetActive(false);
    //     }
    //     muestraNiveles[indiceNivel].SetActive(true);
    // }
}
