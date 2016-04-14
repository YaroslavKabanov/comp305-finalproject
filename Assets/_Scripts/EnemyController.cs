// ********************************************
// * Source file : EnemyController.cs         *
// * Author name : Bridgiet Dhivya Joseph     *
// * Last Modified by : Yaroslav Kabanov      *
// * Last Date Modified : April 12th, 2016    *
// * Program Description : 2D Ninja platformer*
// * Version: 1.0                             *
// ********************************************    
// Git Rero: https://github.com/YaroslavKabanov/comp305-assignment2-2dplatformer-kabanov.git

using UnityEngine;
using System.Collections;


public class EnemyController : MonoBehaviour
{

    // public variables
    public VelocityRange velocityRange;
    public Transform kunaiCheck1;
    public Transform kunaiCheck2;
    public Transform kunaiCheck3;
    public GameController gameController;
    public Transform player;
    public Transform kunai;

    // private variables 
    private Animator _animator;
    private Transform _transform;
    private Rigidbody2D _rigidBody2D;
    private Vector2 _playerCurrentPosition;
    private Vector2 _enemyCurrentPosition;
    private Vector3 _kunaiPosition;
    private float _kunaiForce;
    private int count = 0;


    // Use this for initialization
    void Start()
    {
        // initialize private variables
        this._transform = gameObject.GetComponent<Transform>();
        this._animator = gameObject.GetComponent<Animator>();
        this._rigidBody2D = gameObject.GetComponent<Rigidbody2D>();
        this._animator.SetInteger("Anim_State", 0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this._enemyCurrentPosition = this._transform.position;
        this._playerCurrentPosition = this.player.transform.position;
        if (this._playerCurrentPosition.x + 2000 >= _enemyCurrentPosition.x)
        {
            //throw kunai
            if(count == 40)
            {
                this._animator.SetInteger("Anim_State", 2);
                _kunaiPosition = this._transform.position;
                _kunaiPosition.y = Random.Range(this._transform.position.y - 50, this._transform.position.y + 50);
                Instantiate(this.kunai, _kunaiPosition, Quaternion.identity);
                count = 0;
            }
            else
            {
                count++;
            }
        }             
        else
        {
            this._animator.SetInteger("Anim_State", 0);
        }
    }
}
