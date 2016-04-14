// *************************************************************
// * Source file : CameraController.cs                         *
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

public class CameraController : MonoBehaviour {

	public Transform Hero;
	public Vector3 offset;

	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (Hero.position.x + offset.x, Hero.position.y + offset.y, offset.z);
	}
}
