using System.Collections;
using UnityEngine;

public class cloudMove : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    // get the actual position
		Vector3 position = transform.position;
		// move it with given speed
		position.x += speed;
		// wrap around, if clouds leave screen to the right
		if (position.x > 12f)
			position.x = -12f;
		// set the vector
		transform.position = position; 
    }
    //cr script : office@gemmine.de
}
