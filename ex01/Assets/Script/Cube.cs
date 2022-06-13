using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Cube : MonoBehaviour
{
	public Vector3	vectorDown;
	public string	key;
	private float precision;
	private float border = -3.3f;
	private float randomNbr;
	void Start()
	{
		randomNbr = Random.Range(0.5f, 2f);
	}
	void Update()
    {
	    if (transform.position.y < -10)
		{
			GameObject.Destroy(gameObject);
		}
		if (Input.GetKeyDown(key))
		{
			precision = transform.position.y - border;
			Debug.Log("Precision: " + precision);
			GameObject.Destroy(gameObject);
		}
		transform.Translate(vectorDown * Time.deltaTime / randomNbr);
    }
}
