using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comportamientoPelota : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision){
        if (collision.collider.name == "Pierde")
        {
            Destroy(this.gameObject);         
        }
    }
}
