using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class resultMP : MonoBehaviour
{
    public Text resultText;
    public Text scoreText1;
    public Text scoreText2;
    // Start is called before the first frame update
    void Start()
    {
        scoreText1.text = arrowKananScript.counter.ToString();
        scoreText2.text = arrowScript.counter.ToString();
        if(arrowScript.counter>arrowKananScript.counter)
        {
           resultText.text = "Bravo";
        } else if (arrowScript.counter<arrowKananScript.counter)
        {
           resultText.text = "Mike"; 
        } else {
            resultText.text = "Both"; 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
