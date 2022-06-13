using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Club : MonoBehaviour
{
    public GameObject ball;
    public float speed;

    private float power = 0.0f;

    private Vector3 positionHoll = new Vector3 (0f, 3.8f, 0f);

    private bool hit = false;
    private bool ballMove = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
        {
            transform.position -= new Vector3 (0, 0.01f, 0);
            power += 2f;
            hit = true;
            ballMove = false;
        }
        else if (transform.position.y < ball.transform.position.y - 0.1f && hit && !ballMove)
        {
            
            transform.position += new Vector3 (0, 0.01f, 0);
        }

        if (transform.position.y >= ball.transform.position.y - 0.1f && hit && power > 0f)
        {
            // hit = false;
            ball.transform.Translate(x:0, y:speed * Time.deltaTime * power, z:0);
            // ball.transform.position += new Vector3(0, 0.01f, 0);
            power -= 1f;
            ballMove = true;
        }
        if (power <= 0f)
        {
            ballMove = false;
            hit = false;
            transform.position = ball.transform.position;
        }
    }
}
