﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
 
 public class shootArrowScript2 : MonoBehaviour {
    public float LaunchForce;
    GameObject arrow;
    public GameObject Arrow;
    // Sound effects
    public AudioSource myFX;
	public AudioClip arrowSwoosh;
    public int score = 0;
    public int arrows = 15;
    public Text arrowText;

	bool arrowSwooshSoundPlayed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            Shoot();
        }
    }

    void Shoot(){
        GameObject ArrowIns = Instantiate(Arrow,transform.position,transform.rotation);
        ArrowIns.GetComponent<Rigidbody2D>().AddForce((transform.right*-1) * LaunchForce);
        myFX.PlayOneShot (arrowSwoosh);
        arrows --;
        arrowText.text = arrows.ToString();
        if(arrows==-1){
            SceneManager.LoadScene("halamanGOMP");
    }
    }

 }