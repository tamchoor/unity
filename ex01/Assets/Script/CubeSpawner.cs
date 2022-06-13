using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
	public GameObject cube;
	private float randomNbr;
	void Update()
    {
	    randomNbr = Random.Range(-1000f, 1000f);
	    if (randomNbr > 998)
	    {
		    GameObject.Instantiate(cube, transform);
	    }
    }
}
