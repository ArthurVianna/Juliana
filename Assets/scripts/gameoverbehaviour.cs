using UnityEngine;
using System.Collections;

public class gameoverbehaviour : MonoBehaviour {
	public Transform mesh;
	private Animator gameOver;
	void Start(){
		gameOver = mesh.GetComponent <Animator> ();
	}
	// Update is called once per frame
	void Update () {
	   if (morte.Acertado == true)
						gameOver.SetBool ("Morto", true);
	}
}
