using UnityEngine;
using System.Collections;

public class heartbehaviour : MonoBehaviour {
	public GameObject H1;
	public GameObject H2;
	public GameObject H3;
	
	void Update () {
	   if (morte.vidas == 2) {
						H1.SetActive (false);
				}
		if (morte.vidas == 1) {
			H1.SetActive (false);
						H2.SetActive (false);
				
		}
		if (morte.vidas == 0) {
						H1.SetActive (false);
						H2.SetActive (false);
						H3.SetActive (false);
				}
	}
}
