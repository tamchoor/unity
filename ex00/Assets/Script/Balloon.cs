using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Balloon : MonoBehaviour
{
    public Vector3 scaleChange;
    public Vector3 posChange;
    public float breathless;
    public Vector3 minScale;
    public Vector3 maxScale;
    private float playTime = 0;
    void Update()
    {
        if (transform.localScale.x >= maxScale.x || transform.localScale.x <= minScale.x)
        {
            Debug.Log("Balloon life time: " + Mathf.RoundToInt(playTime) + "s");
            GameObject.Destroy(this);
        }
        if (Input.GetKeyDown("space"))
        {
            if (breathless > 0)
            {
                transform.localScale += scaleChange;
                transform.position += posChange;
            }
            breathless -= 1;
        }
        playTime += Time.deltaTime;
        transform.localScale -= (scaleChange * Time.deltaTime) * 2;
        transform.position -= (posChange * Time.deltaTime) * 2;
        if (breathless < 10)
            breathless += 2 * Time.deltaTime;
    }
}
