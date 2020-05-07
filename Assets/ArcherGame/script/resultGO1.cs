using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class resultGO1 : MonoBehaviour
{
    public Text resultText;

    // Start is called before the first frame update
    void Start()
    {
        resultText.text = arrowScript.counter.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
