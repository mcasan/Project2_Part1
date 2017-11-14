using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	
	int Xposition;

	public GameObject currentCube;

	public GameObject cubePre;

	public static GameObject redcube;

	GameObject[]cubeRow = new GameObject[16];

	Vector3 cubePosition;




	// Use this for initialization


		/// This is to position the cubes, white color to the cube and, to make no more that 16 cubes.


	void Start () {

		Xposition = -2;

		cubePosition = new Vector3 (14, 0, 0);
			
		for (int i = 0; i < 16; i++){
			

			cubeRow[i]	 = (GameObject) Instantiate (cubePre, cubePosition, Quaternion.identity);

			cubePosition += new Vector3 (Xposition, 0, 0);

			cubeRow[i].GetComponent<Renderer> ().material.color = Color.white;


		}

	}
	
	// Update is called once per frame
	void Update () {



		
	}
}
