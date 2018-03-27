using UnityEngine;
using System.Collections;

public class dogbehaviour : MonoBehaviour {
	public float forcaPulo;
	public float forcaAnda;
	public static bool Ganhou = false;
	public bool Acertado = true;
	public bool vaiProlado = false;
	public bool direitaEsquerda = false;
	// Use this for initialization
	void OnCollisionEnter2D(Collision2D collider)
	{
		if (collider.gameObject.tag == "osso") {
			Ganhou = true;
		}
		if (collider.gameObject)
			Acertado = true;
		    vaiProlado = false;
		}
	// Update is called once per frame
	void Update () {
		if (Ganhou == false && morte.Acertado == false && Acertado == true && Input.GetKeyDown ("space")) {
						gameObject.audio.Play ();
						Acertado = false;
						rigidbody2D.velocity = Vector2.zero;
						rigidbody2D.AddForce (new Vector2 (0, 1) * forcaPulo);
				} 
		else {
		if (morte.Acertado == true)
			{
			    if (Input.GetKeyDown ("space"))
				{
					Application.LoadLevel (Application.loadedLevel);
				}
			}
		}
		if (vaiProlado == false && Acertado == false && Input.GetKeyDown (KeyCode.RightArrow)) {
			if (direitaEsquerda == true)
			{
				direitaEsquerda = false;
			transform.Rotate (new Vector3(1,0,1)* 180);      
			}
			vaiProlado = true;
			            rigidbody2D.AddForce (new Vector2 (1, 0) * forcaAnda);		
		}
		if (vaiProlado == false && Acertado == false && Input.GetKeyDown (KeyCode.LeftArrow)) {            
			if (direitaEsquerda == false){
				direitaEsquerda = true;
				transform.Rotate (new Vector3(1,0,1)* 180);      
			}
			vaiProlado = true;
			            rigidbody2D.AddForce (new Vector2 (-1, 0) * forcaAnda);		
		}
	}
}