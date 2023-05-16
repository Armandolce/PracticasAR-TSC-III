using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comportamientoPelota : MonoBehaviour
{
    public Transform initialPosition;
    
    public void OnCollisionEnter(Collision collision){
        if (collision.gameObject.name == "DeathWall")
        {
            this.transform.position = initialPosition.position;
        }//else if(collision.gameObject.name == "Final"){
        //     Color customColor = new Color(0.0f, 0.9f, 0.1f, 1.0f);
        //     var NewObject = this.GetComponent<Renderer>();
        //     NewObject.material.SetColor("_Color", customColor);
        // }
    }
}
