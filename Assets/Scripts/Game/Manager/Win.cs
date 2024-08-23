using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public GameObject TextWin;

    void OnTriggerEnter2D(Collider2D other){
        TextWin.SetActive(true);
        Time.timeScale = 0f;
    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.R)){
            TextWin.SetActive(false);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Time.timeScale = 1f;
        }
    }
}
