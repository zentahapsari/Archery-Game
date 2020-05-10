using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class restartScript : MonoBehaviour
{
    
    void Start(){
        RestartGame();
    }
    public void RestartGame()
    {
    // SceneManager.LoadScene("halamanGO1");
    arrowScript.counter = 0;
    arrowKananScript.counter = 0;
    }
}
