using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_Behavior : MonoBehaviour {
	
public GameObject cubePrep;

/// When the mouse is cliking, it can change the color of a white cube to a red cube.

	void OnMouseDown () {


		if (GameController.redcube != null) {

			GameController.redcube.GetComponent<Renderer> ().material.color = Color.white;
			}


		gameObject.GetComponent<Renderer>().material.color = Color.red;

		GameController.redcube = gameObject;


	}
}