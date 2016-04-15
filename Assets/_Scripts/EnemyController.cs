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
using UnityEngine.UI;

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
    public Slider enemyHealthSlider;

    // private variables 
    private Animator _animator;
    private Transform _transform;
    private Rigidbody2D _rigidBody2D;
    private Vector2 _playerCurrentPosition;
    private Vector2 _enemyCurrentPosition;
    private Vector3 _kunaiPosition;
    private float _kunaiForce;
    private int count = 0;
    private bool _isAttacked1;
    private bool _isAttacked2;
    private bool _isAttacked3;
    private bool _dead;

    // Use this for initialization
    void Start()
    {
        // initialize private variables
        this._transform = gameObject.GetComponent<Transform>();
        this._animator = gameObject.GetComponent<Animator>();
        this._rigidBody2D = gameObject.GetComponent<Rigidbody2D>();
        this._animator.SetInteger("Anim_State", 0);
        this._dead = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (this.enemyHealthSlider.value > 0 && !_dead)
        {
            this._isAttacked1 = Physics2D.Linecast(
                    this._transform.position,
                    this.kunaiCheck1.position,
                    1 << LayerMask.NameToLayer("HeroKunai"));
            Debug.DrawLine(this._transform.position, this.kunaiCheck1.position);

            this._isAttacked2 = Physics2D.Linecast(
                        this._transform.position,
                        this.kunaiCheck2.position,
                        1 << LayerMask.NameToLayer("HeroKunai"));
            Debug.DrawLine(this._transform.position, this.kunaiCheck2.position);

            this._isAttacked3 = Physics2D.Linecast(
                        this._transform.position,
                        this.kunaiCheck3.position,
                        1 << LayerMask.NameToLayer("HeroKunai"));
            Debug.DrawLine(this._transform.position, this.kunaiCheck3.position);

            this._enemyCurrentPosition = this._transform.position;
            this._playerCurrentPosition = this.player.transform.position;

            if (this._isAttacked1 || this._isAttacked2 || this._isAttacked3)
            {
                this._animator.SetInteger("Anim_State", 1);
            }
            else if (this._playerCurrentPosition.x + 2000 >= _enemyCurrentPosition.x)
            {
                //throw kunai
                if (count == 40)
                {
                    this._animator.SetInteger("Anim_State", 2);
                    _kunaiPosition = this._transform.position;
                    _kunaiPosition.y = Random.Range(this._transform.position.y - 10, this._transform.position.y + 10);
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
        else
        {
            this._animator.SetInteger("Anim_State", 3);
            this._dead = true;
            StartCoroutine(this._die());
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        //enemy collision 
        if (enemyHealthSlider.value > 0 && (other.gameObject.CompareTag("Player") || other.gameObject.CompareTag("HeroKunai")))
        {
            this.enemyHealthSlider.value -= 0.2f;
        }
    }


//call if the meowth gets hurt
private IEnumerator _die()
{
    this.gameController.ScoreValue += 100;
    yield return new WaitForSeconds(1.0f);
    Destroy(this.gameObject);
}
}
