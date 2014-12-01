using UnityEngine;
using System.Collections;

public class Rocket : MonoBehaviour {

    float timeout = 4;
    float speed = 12;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
        transform.position += this.transform.forward * (Time.deltaTime * speed);
        timeout -= Time.deltaTime;

        if (timeout <= 0f)
        {
            Destroy(this.gameObject);
        }
	}

    void OnTriggerEnter(Collider other)
    {
 
    }
}
