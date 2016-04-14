// *************************************************************
// * Source file : DiamondControllerLevel2.cs                  *
// * Author name : Yaroslav Kabanov & Bridgiet Dhivya Joseph   *
// * Last Modified by : Yaroslav Kabanov                       *
// * Last Date Modified : April 17th , 2016                    *
// * Program Description : 2D Ninja platformer, contains 3     *
// * different levels.                                         *
// * Version: 1.0                                              *
// *************************************************************    
// Git Rero: https://github.com/YaroslavKabanov/comp305-finalproject.git

using UnityEngine;
using System.Collections;

public class DiamondControllerLevel2 : MonoBehaviour {

	// public variables 
	public int diamondsAmount = 15;
	public int verticalMin = 667;
	public int verticalMax = 4500;
	public int horizontalMin = 35;
	public int horizontalMax = 948; 


	// private variables 
	private GameObject diamond;
	private Vector2 _startPosition; 



	// Use this for initialization
	void Start () {
		diamond = GameObject.Find("diamond");
		Respawn ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D (Collision2D col) {
		//if (col.gameObject.tag == "Player") {
			Destroy (col.gameObject);
	
		//}
	}
	// respawn diamond when game starts
	void Respawn () {
		
		for (int i = 0; i < diamondsAmount; i++) {
			Vector2 randomPosition = new Vector2 (Random.Range (horizontalMin, horizontalMax), Random.Range (verticalMin, verticalMax));
			Instantiate (diamond, randomPosition, Quaternion.identity);
			this._startPosition = randomPosition;
		}

	}
}