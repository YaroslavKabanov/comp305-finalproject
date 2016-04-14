// *************************************************************
// * Source file : GameControllerStart.cs                      *
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
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControllerEnd : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// start new game after start button being clicked
	public void LoadGameEndMenu () {
		SceneManager.LoadScene ("Main");
	}

    public void GameHomeEndMenu()
    {
        SceneManager.LoadScene("StartScene");
    }
}
