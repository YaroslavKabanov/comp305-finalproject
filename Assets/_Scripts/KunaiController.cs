using UnityEngine;
using System.Collections;

public class KunaiController : MonoBehaviour {

    private float _kunaiSpeed;
    private Transform _transform;
	// Use this for initialization
	void Start () {
	    _transform= gameObject.GetComponent<Transform>();
        _kunaiSpeed = 700f;
    }
	
	// Update is called once per frame
	void Update () {
        float amtToMove = _kunaiSpeed * Time.deltaTime;
        _transform.Translate(Vector3.left * amtToMove); 
	    if(_transform.position.x < -1000f)
        {
            Destroy(gameObject);
        }
	}
}
