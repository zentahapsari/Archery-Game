using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnFX : MonoBehaviour
{
    public AudioSource myFX;
    public AudioClip hoverFX;
    public AudioClip clickFX;
    // Start is called before the first frame update
    public void HoverSound(){
    myFX.PlayOneShot (hoverFX);
        
    }

    public void ClickSound(){
    myFX.PlayOneShot (clickFX);
        
    }
   
}
