using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToMenu : MonoBehaviour
{
    public GameObject ToMenuText, WinText, LossText;

    void Update(){
        if (Input.GetKeyDown(KeyCode.Escape)){
            if((ToMenuText.activeSelf)||(WinText.activeSelf)){
                SceneManager.LoadScene(0);
            }
            else{
                Time.timeScale = 0f;
                LossText.SetActive(false);
                ToMenuText.SetActive(true);
            }
        }
        if (Input.GetKeyDown(KeyCode.Space)){
            ToMenuText.SetActive(false);
            Time.timeScale = 1f;
        }
    }
}
