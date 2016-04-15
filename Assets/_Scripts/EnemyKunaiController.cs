using UnityEngine;
using System.Collections;

public class KunaiController : MonoBehaviour {
    private float _kunaiSpeed;
    private Transform _transform;
    private string _directionValue;

    public string Direction
    {
        get
        {
            return this._directionValue;
        }

        set
        {
            this._directionValue = value;
        }
    }

	// Use this for initialization
	void Start () {
	    _transform= gameObject.GetComponent<Transform>();
        _kunaiSpeed = 700f;
    }
	
	// Update is called once per frame
	void Update () {
        float amtToMove = _kunaiSpeed * Time.deltaTime;
        if(this._directionValue == "LEFT")
        {
            _transform.Translate(Vector3.left * amtToMove);
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
            _transform.Translate(Vector3.right * amtToMove);
        }

	    if(this._directionValue == "LEFT" && this._transform.position.x < -1000f)
        {
            Destroy(gameObject);
        }
        else if(this._directionValue == "RIGHT" && this._transform.position.x < -5000f)
        {
            Destroy(gameObject);
        }
	}
}
