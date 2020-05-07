using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
 
 public class shootArrowScript : MonoBehaviour {
    public float LaunchForce;
    public GameObject Arrow;
    public GameObject risingText;
    public GameObject target;
    // Sound effects
    public AudioSource myFX;
	public AudioClip arrowSwoosh;
    public int score = 0;
    public int arrows = 20;

    	// has sound already be played
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
        ArrowIns.GetComponent<Rigidbody2D>().AddForce(transform.right * LaunchForce);
        myFX.PlayOneShot (arrowSwoosh);
    }

	public void setPoints(int points){
		score += points;
		if (points == 1) {
			GameObject rt1 = (GameObject)Instantiate(risingText, new Vector3(0,0,0),Quaternion.identity);
			rt1.transform.position = this.transform.position + new Vector3(0,0,0);
			rt1.transform.name = "rt1";
			// each target's "ring" is 0.07f wide
			// so it's relatively simple to calculate the ring hit (thus the score)
			rt1.GetComponent<TextMesh>().text= "Bonus arrow";
		}
	}
//source code : https://www.youtube.com/watch?v=buZ6h-OlUOU
 }