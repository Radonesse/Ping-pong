using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lose : MonoBehaviour
{
    public GameObject TextLose;

    void OnTriggerEnter2D(Collider2D other){
        TextLose.SetActive(true);
        Time.timeScale = 0f;
    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.R)){
            TextLose.SetActive(false);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Time.timeScale = 1f;
        }
    }
}
