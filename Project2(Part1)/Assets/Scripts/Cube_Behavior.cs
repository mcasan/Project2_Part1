using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_Behavior : MonoBehaviour {
	
public GameObject cubePrep;

	void OnMouseDown () {


		if (GameController.redcube != null) {

			GameController.redcube.GetComponent<Renderer> ().material.color = Color.white;
			}


		gameObject.GetComponent<Renderer>().material.color = Color.red;

		GameController.redcube = gameObject;


	}
}