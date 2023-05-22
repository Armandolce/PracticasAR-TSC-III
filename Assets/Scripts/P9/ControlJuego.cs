using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ControlJuego : MonoBehaviour
{
    public GameObject []muestraNiveles;
    public ControlNivel []controladorNiveles;
    
    public int intentosTotal;
    public int indiceNivel;
    
    [SerializeField] private TextMeshProUGUI CanvaIntentosTot;
    [SerializeField] private TextMeshProUGUI CanvaIntentosLvl;
    [SerializeField] private TextMeshProUGUI TiempoRestante;
    public GameObject General, win, lose;

    private float Timer;
    private int min, seg, cent;
    private bool finish;
    private float startTime, elapsedTime;

    // Start is called before the first frame update
    void Start()
    {
        foreach (var levels in muestraNiveles)
        {
            levels.SetActive(false);
        }
        muestraNiveles[0].SetActive(true);

        startTime = Time.time;
        Timer = 50.0f;
        finish = false;
        intentosTotal = 0;
        indiceNivel = 0;
        General.SetActive(true);
        win.SetActive(false);
        lose.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
        if (!finish)
        {
            Timer -= Time.deltaTime;
            //elapsedTime = Time.time - startTime;
            elapsedTime = (startTime+50.0f) - Time.time;
        }

        min = (int)(Timer / 60f);
        seg = (int)(Timer - min * 60f);
        cent = (int)( (Timer - (int)Timer) * 100f);

        TiempoRestante.text = string.Format("{0:00}:{1:00}:{2:00}", min, seg, cent);

        if (Timer <= 0.0f)
        {
            Timer = 0.0f;
            General.SetActive(true);
            win.SetActive(false);
            lose.SetActive(true);
        }


        CanvaIntentosTot.text = intentosTotal.ToString();
        CanvaIntentosLvl.text = controladorNiveles[indiceNivel].intentos.ToString(); 
    }
    public void ControlIntentos(){
        foreach( var level in controladorNiveles)
        {
            intentosTotal += level.intentos;
        }
        Timer = elapsedTime;
        General.SetActive(true);
        win.SetActive(true);
        lose.SetActive(false);
        finish = true;
    }

    public void Reinicio()
    {
        Start();
        foreach (var level in controladorNiveles)
        {
            level.intentos = 1;
        }
    }
}
