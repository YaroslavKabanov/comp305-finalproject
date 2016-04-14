using UnityEngine;
using System.Collections;

public class CameraControllerLevel2 : MonoBehaviour {

	// PUBLIC INSTANCE VARIABLES
	public float speed = 1f;
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


		if (this._currentPosition.y >= 4200) {
			speed = 0; 
		}
	}
}
