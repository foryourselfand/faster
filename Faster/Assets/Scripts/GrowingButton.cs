using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowingButton : MonoBehaviour
{
	public float speed;
	public Vector3 target = new Vector3(1, 1, 1);
	
	// Use this for initialization
	void Start () {
		transform.localScale = new Vector3(0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		transform.localScale = Vector3.MoveTowards (transform.localScale, target, Time.deltaTime * speed);
	}
}
