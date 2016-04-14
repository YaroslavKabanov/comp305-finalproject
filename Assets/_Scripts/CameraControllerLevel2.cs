// *************************************************************
// * Source file : GameraControllerLevel2.cs                   *
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

public class CameraControllerLevel2 : MonoBehaviour {

	// PUBLIC INSTANCE VARIABLES
	public float speed = 1.5f;
	public Vector3 offset;

	// PRIVATE INSTANCE VARIABLE 
	private Transform _transform;
	private Vector3 _currentPosition;




	// Use this for initialization
	void Start () {
		this._transform = gameObject.GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		this._currentPosition = this._transform.position; 
		this._currentPosition += new Vector3 (0, this.speed);
		this._transform.position = this._currentPosition; 


		if (this._currentPosition.y >= 4500) {
			speed = 0; 
		}
	}
}
