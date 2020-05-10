using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objAwake : MonoBehaviour
{
    private void Awake(){
        DontDestroyOnLoad(this.gameObject);
    }
}
