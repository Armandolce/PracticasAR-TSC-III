using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinGame : MonoBehaviour
{
    public GameObject Object;
    public void OnTriggerEnter (Collider other){

        if (other.tag == "Pelota")
        {
            var NewObject = Object.GetComponent<Renderer>();
            Color customColor = new Color(0.0f, 0.9f, 0.1f, 1.0f);
            NewObject.material.SetColor("_Color", customColor);
        }
    }
    public void OnTriggerExit (Collider other){

        if (other.tag == "Pelota")
        {
            var NewObject = Object.GetComponent<Renderer>();
            Color customColor = new Color(1.0f, 0.0f, 0.0f, 1.0f);
            NewObject.material.SetColor("_Color", customColor);
        }
    }
}
