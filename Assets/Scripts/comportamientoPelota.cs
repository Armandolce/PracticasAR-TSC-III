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
        }
    }
}
