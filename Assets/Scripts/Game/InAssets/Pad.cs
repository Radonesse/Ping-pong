using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pad : MonoBehaviour
{
    private Rigidbody2D pad;
    private float horizontal, speed = 10f;

    private void Awake(){
        pad = GetComponent<Rigidbody2D>();
    }

    private void Update(){
        horizontal = Input.GetAxis("Horizontal")*speed;
        pad.velocity = transform.TransformDirection(new Vector2(horizontal, 0));
    }
}
