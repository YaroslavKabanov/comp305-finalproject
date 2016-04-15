using UnityEngine;
using System.Collections;

public class HeroKunaiController : MonoBehaviour {
    private float _kunaiSpeed;
    private Transform _transform;
    private bool faceRight;

    public bool FaceRightDir
    {
        set
        {
            faceRight = value;
        }
        get
        {
            return faceRight;
        }
    }

    // Use this for initialization
    void Start() {
        _transform = gameObject.GetComponent<Transform>();
        _kunaiSpeed = 700f;
    }

    // Update is called once per frame
    void Update() {
        float amtToMove = _kunaiSpeed * Time.deltaTime;
        if (!this.faceRight)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
            _transform.Translate(Vector3.left * amtToMove);
        }
        else if (this.faceRight)
        {
            _transform.Translate(Vector3.right * amtToMove);
        }

        //if (!this.faceRight && this._transform.position.x < -1000f)
        //{
        //    Destroy(gameObject);
        //}
        //else if (this.faceRight && this._transform.position.x < -5000f)
        //{
        //    Destroy(gameObject);
        //}
    } 
}


