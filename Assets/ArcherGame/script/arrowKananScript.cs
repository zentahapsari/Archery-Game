using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class arrowKananScript : MonoBehaviour
{
    Rigidbody2D rb;
    GameObject arrow;
    // public GameObject Arrow;
    public GameObject risingText;
    public GameObject target;
    public GameObject arrowPrefab;
    bool isActive = true;
    public static int counter = 0;
    public int arrows = 20;
    public static int panah = 0;
    public int actScore = 1;
    public Text scoreText;
    public Text scoreText1;
    public Text arrowText1;
    Vector2 throwForce;
    Vector3 originalPos;

    BoxCollider2D arrowCollider;
    public AudioSource myFX;
	public AudioClip arrowTarget;
    public AudioClip speakUp;
    // Start is called before the first frame update
    void Start()
    {     
        originalPos = new Vector3(10,-5,0);
        rb = GetComponent<Rigidbody2D>();
        arrowCollider = GetComponent<BoxCollider2D>();
        scoreText1.text = arrowScript.counter.ToString();
        arrowText1.text = panah.ToString();
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

        if(col.collider.tag == "apple2")
        {
            rb.velocity = new Vector2(0,0);
            rb.bodyType = RigidbodyType2D.Kinematic;
            this.transform.SetParent(col.collider.transform);
        
            arrowCollider.offset = new Vector2 (arrowCollider.offset.x, -0.4f);
            arrowCollider.size = new Vector2 (arrowCollider.size.x,-2);
            counter++;
            scoreText.text = counter.ToString();
            myFX.PlayOneShot (arrowTarget);
            // create a rising text for score display
			GameObject rt = (GameObject)Instantiate(risingText, new Vector3(0,0,0),Quaternion.identity);
			rt.transform.position = col.transform.position + new Vector3(-1,1,0);
			rt.transform.name = "rt";
			rt.GetComponent<TextMesh>().text= "+"+actScore;
            transform.position=originalPos;
        }
        else if(col.collider.tag == "tokohbiru")
        {
            rb.velocity = new Vector2(0,0);
            rb.bodyType = RigidbodyType2D.Kinematic;
            this.transform.SetParent(col.collider.transform);
        
            arrowCollider.offset = new Vector2 (arrowCollider.offset.x, -0.4f);
            arrowCollider.size = new Vector2 (arrowCollider.size.x,-2);
            // counter--;
            // scoreText.text = counter.ToString();
            myFX.PlayOneShot (speakUp);

            // // create a rising text for score display
			// GameObject rt1 = (GameObject)Instantiate(risingText, new Vector3(0,0,0),Quaternion.identity);
			// rt1.transform.position = col.transform.position + new Vector3(-1,1,0);
			// rt1.transform.name = "rt1";
			// rt1.GetComponent<TextMesh>().text= "-"+actScore;
            transform.position=originalPos;
            

        }
        else if (col.collider.tag == "arrow2")
        {
            rb.velocity = new Vector2 (rb.velocity.x,-2);
            // gameObject.transform.position = originalPos;
        }
    }

//     void OnTriggerEnter(Collider other)
//   {
//       if(other.gameObject.tag == "arrow")
//       {
//           gameObject.transform.position = originalPos;
//       }
    
//   }
}
