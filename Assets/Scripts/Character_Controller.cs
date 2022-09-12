using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Controller : MonoBehaviour
{
    public Rigidbody2D rB;
    public Animator _animator;

    public float _speed;

    private float _moveX;

    private void Start()
    {
        
    }

    private void Update()
    {
        _moveX = Input.GetAxis("Horizontal");
        rB.velocity = new Vector2(_moveX * _speed, rB.velocity.y);

        HeroDirection();

        if (_moveX != 0)
        {
            _animator.SetBool("isRun", true);
        }
        else if (_moveX ==0)
        {
            _animator.SetBool("isRun", false);
        }
    }

    private void HeroDirection()
    {
        if (_moveX >= 0)
        {
            transform.localScale = new Vector2(1f, 1f);
        }
        else if (_moveX <= 0)
        {
            transform.localScale = new Vector2(-1f, 1f);
        }
    }
}
