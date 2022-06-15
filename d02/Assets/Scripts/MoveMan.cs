using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMan : MonoBehaviour
{
    public float step;
    public float inaccuracy;
    public AudioClip goClip;
    private Vector2 _startPoz;
    private Vector2 _secondPoz;
    private Vector2 _direction;
    private Camera _cam;

    private Animator animator;

    private bool _go;
    
    
    private AudioSource audioSource;
    
    // Start is called before the first frame update
    void Start()
    {
        _go = false;
        _secondPoz = transform.position;
        _cam = Camera.main;
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, _secondPoz) < inaccuracy)
        {
             _go = false;
            
             animator.ResetTrigger("BlendTree_walk");
        }
           
        if (Input.GetMouseButtonDown(0))
        {
            _startPoz = transform.position; 
            audioSource.Play();
            _secondPoz = (Vector2) _cam.ScreenToWorldPoint(Input.mousePosition);
            _direction = (_secondPoz - _startPoz).normalized;
            _go = true;
        }
    }
    
    void FixedUpdate()
    {
        // Debug.Log(_secondPoz.normalized);
        if (_go)
        {
            animator.SetFloat("vX", _direction.x * 2);
            animator.SetFloat("vY", _direction.y * 2);
            animator.SetTrigger("BlendTree_walk");
            Debug.Log("vX = " + _direction.x * 2 + "vY = " + _direction.y * 2);
            transform.position += (Vector3) _direction * step;
        }
    }
}
