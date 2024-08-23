using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
public class Manager : MonoBehaviour
{
    public float hight, width;
    public Transform left, right;

    public void Awake(){
        hight = Camera.main.orthographicSize;
        width = hight * Camera.main.aspect;
        left.position = new Vector3(-0.5f-width, 0, 0);
        right.position = new Vector3(0.5f+width, 0, 0);
    }
}
