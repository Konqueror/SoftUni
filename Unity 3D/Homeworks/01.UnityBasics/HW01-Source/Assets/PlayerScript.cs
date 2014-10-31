using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour 
{

	// speed
    public float Speed = 5.0f;

	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	    Move();
	}

	// players movement
    void Move()
    {
        float deltaX = Input.GetAxis("Horizontal");
        float deltaY = Input.GetAxis("Vertical");

        this.transform.rigidbody2D.velocity = new Vector2(deltaX, deltaY) * Speed;
    }

}
