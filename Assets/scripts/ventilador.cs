using UnityEngine;
using System.Collections;

public class ventilador : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	public bool ventila = false;
	public LayerMask vento;
	void OnCollisionEnter2D(Collision2D collider)
	{	



	}
	
	// Update is called once per frame
	void Update () {


		if (ventila) {
			rigidbody2D.velocity = Vector2.zero;
			rigidbody2D.AddForce (new Vector2 (0, 1) * 555);
		}

	
	}
}
