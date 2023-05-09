using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPelotas : MonoBehaviour
{
    public GameObject pelotas;
    public Transform posicionInical;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.getKeyDown(KeyCode.BackSpace))
        {
           Instantiate(pelotas, posicionInical);
        }
    }
}
