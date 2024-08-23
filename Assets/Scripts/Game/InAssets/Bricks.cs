using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.layer == 3){
            Destroy(other.gameObject);
        }
    }
}
