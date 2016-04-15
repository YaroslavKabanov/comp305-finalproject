using UnityEngine;
using System.Collections;

public class EnemyKunaiController : MonoBehaviour {
    private float _kunaiSpeed;
    private Transform _transform;
    private string _directionValue;
    private float _verticalDrift;
    
    // Use this for initialization
    void Start () {
	    _transform= gameObject.GetComponent<Transform>();
        _kunaiSpeed = 600f;
    }
	
	// Update is called once per frame
	void Update () {
        float amtToMove = _kunaiSpeed * Time.deltaTime;
        _transform.Translate(Vector3.left * amtToMove);
        if (this._transform.position.x < -1000f)
        {
            Destroy(gameObject);
        }
	}

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.gameObject.CompareTag("Enemy") && !other.gameObject.CompareTag("EnemyBlock"))
        {
            Destroy(gameObject);
        }

        if (other.gameObject.CompareTag("Diamond"))
        {
            Destroy(other.gameObject);
        }
    }
}
