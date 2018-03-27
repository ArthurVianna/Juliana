using UnityEngine;
using System.Collections;

public class wingamebehaviour : MonoBehaviour {
	public Transform mesh;
	private Animator gameWin;
	void Start(){
		gameWin = mesh.GetComponent <Animator> ();
	}
	// Update is called once per frame
	void Update () {
		if (dogbehaviour.Ganhou == true)
			gameWin.SetBool ("Ganhou", true);
	}
}
