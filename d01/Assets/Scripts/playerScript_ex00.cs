using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript_ex00 : MonoBehaviour
{
    private Rigidbody2D rigidbody2d;
    private float _horizontal; 
    private bool _vertical = false;
    private bool _onGround = true;
    public bool _play;

    private Vector2 position;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_play)
        {
            _horizontal = Input.GetAxis("Horizontal");
            if (!_vertical && Input.GetKeyDown("space") && _onGround)
            {
                _vertical = true;
            }
        }
    }
    void FixedUpdate()
    {
        position = rigidbody2d.position;
        position.x = position.x + 5.0f * _horizontal * Time.deltaTime;
       
        if (_vertical)
        {
            _onGround = false;
            Debug.Log(_vertical);
            position.y = position.y + 200.0f * Time.deltaTime;
            _vertical = false;
        }
        rigidbody2d.MovePosition(position);
    }
    
    void OnCollisionEnter2D()
    {
        _onGround = true;
    }
}
