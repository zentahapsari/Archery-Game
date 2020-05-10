using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class resultGO2 : MonoBehaviour
{
    public Text resultText;
    public Text resultText1;
    public Text resultText2;
    // Start is called before the first frame update
    void Start()
    {
        resultText.text = arrowKananScript.counter.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
