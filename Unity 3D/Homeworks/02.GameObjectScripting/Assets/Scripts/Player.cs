using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
		float speed = 12;
		Camera mainCamera;
		float rotationSpeed = 100f;

		// Use this for initialization
		void Start ()
		{
				mainCamera = GameObject.Find ("Main Camera").GetComponent<Camera> ();
		}
	
		// Update is called once per frame
		void Update ()
		{
				float translation = rotationSpeed * Input.GetAxis ("Mouse X");
				float rotation = rotationSpeed * Input.GetAxis ("Mouse Y");
				translation *= Time.deltaTime;
				rotation *= Time.deltaTime;

				mainCamera.transform.eulerAngles = new Vector3 (mainCamera.transform.localRotation.eulerAngles.x - rotation, transform.eulerAngles.y, 0f);
				transform.eulerAngles = new Vector3 (0f, transform.localRotation.eulerAngles.y + translation, 0f);

				if (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.UpArrow)) {
						transform.localPosition += transform.TransformDirection (Vector3.forward) * speed * Time.deltaTime;
				}

				if (Input.GetKey (KeyCode.S) || Input.GetKey (KeyCode.DownArrow)) {
						transform.localPosition += transform.TransformDirection (Vector3.back) * speed * Time.deltaTime;
				}

				if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) {
						transform.localPosition += transform.TransformDirection (Vector3.right) * speed * Time.deltaTime;
				}

				if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) {
						transform.localPosition += transform.TransformDirection (Vector3.left) * speed * Time.deltaTime;
				}
		}
}
