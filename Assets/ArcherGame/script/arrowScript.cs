using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class arrowScript : MonoBehaviour
{
    Rigidbody2D rb;
    GameObject arrow;
    public GameObject risingText;
    public GameObject target;
    public GameObject arrowPrefab;
    bool isActive = true;
    public static int counter = 0;
    public static int counter1 = 0;
    public static int counter2 = 0;
    public int arrows = 15;
	public int score = 0;
    public int actScore = 1;
    public Text scoreText;
    public Text scoreText1;
    public Text scoreText2;
    public Text arrowText;
    Vector2 throwForce;
    Vector3 originalPos;

    BoxCollider2D arrowCollider;
    public AudioSource myFX;
	public AudioClip arrowTarget;
    public AudioClip speakUp;
    // Start is called before the first frame update
    void Start()
    {     
        originalPos = new Vector3(-10,-5,0);
        rb = GetComponent<Rigidbody2D>();
        arrowCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isActive)
        {
            rb.AddForce(throwForce,ForceMode2D.Impulse);
            rb.gravityScale = 1;
        }
    }


    void OnCollisionEnter2D(Collision2D col) {
        if(!isActive)
        return;

        isActive = false;
    // if (arrows > 0){
        if(col.collider.tag == "apple")
        {
            rb.velocity = new Vector2(0,0);
            rb.bodyType = RigidbodyType2D.Kinematic;
            this.transform.SetParent(col.collider.transform);
        
            arrowCollider.offset = new Vector2 (arrowCollider.offset.x, -0.4f);
            arrowCollider.size = new Vector2 (arrowCollider.size.x,-2);
            counter++;

            scoreText.text = counter.ToString();
            // scoreText1.text = counter1.ToString();
            // scoreText2.text = counter2.ToString();
            myFX.PlayOneShot (arrowTarget);
            // create a rising text for score display
			GameObject rt = (GameObject)Instantiate(risingText, new Vector3(0,0,0),Quaternion.identity);
			rt.transform.position = col.transform.position + new Vector3(-1,1,0);
			rt.transform.name = "rt";
			rt.GetComponent<TextMesh>().text= "+"+actScore;
            transform.position=originalPos;
            // arrows --;
            // arrowText.text = arrows.ToString();
        }
        else if(col.collider.tag == "tokohmerah" )
        {
            rb.velocity = new Vector2(0,0);
            rb.bodyType = RigidbodyType2D.Kinematic;
            this.transform.SetParent(col.collider.transform);
        
            arrowCollider.offset = new Vector2 (arrowCollider.offset.x, -0.4f);
            arrowCollider.size = new Vector2 (arrowCollider.size.x,-2);
            // counter--;
            // scoreText.text = counter.ToString();
            transform.position=originalPos;
            myFX.PlayOneShot (speakUp);

            // create a rising text for score display
			// GameObject rt1 = (GameObject)Instantiate(risingText, new Vector3(0,0,0),Quaternion.identity);
			// rt1.transform.position = col.transform.position + new Vector3(-1,1,0);
			// rt1.transform.name = "rt1";
			// rt1.GetComponent<TextMesh>().text= "Your next move will be your last!";
            // transform.position=originalPos;
            

        }
        else if (col.collider.tag == "arrow")
        {
            rb.velocity = new Vector2 (rb.velocity.x,-2);
        }

    // }
    }


}
