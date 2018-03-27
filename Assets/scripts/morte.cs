using UnityEngine;
using System.Collections;
public class morte : MonoBehaviour {
	public static bool Acertado = false;
	public static int vidas = 3;
	// Use this for initialization
	void Update () { 
	     if (Acertado == true && Input.GetKeyDown ("space")) {
			Acertado = false;
			vidas = 3;
		}
	}
	void OnCollisionEnter2D(Collision2D collider)
	{
		if (collider.gameObject.tag == "morte") {
			vidas -= 1;
			if (vidas > 0)
			{
			Application.LoadLevel (Application.loadedLevel);
			}
			else
				Acertado = true;
		}
	}
}
