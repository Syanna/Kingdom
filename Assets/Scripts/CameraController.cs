using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	public float speed = 0.1f;
	public Transform target;
	Camera mycam;
	// Use this for initialization
	void Start () {
		mycam = GetComponent<Camera> ();

	}
	
	// Update is called once per frame
	void Update () {
		mycam.orthographicSize = (Screen.height) / 2f;
		if (target) {
			transform.position = Vector3.Lerp (transform.position, target.position, speed) + new Vector3(0,0,-10);
		}

		        
	}
}
