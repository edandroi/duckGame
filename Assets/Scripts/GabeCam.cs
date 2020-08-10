using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GabeCam : MonoBehaviour
{
	public Transform player;

	public float distanceFromPlayer;

	public float lerpSpeed = .2f;
	
	private void Awake()
	{
	}

	private void Start()
	{
//		distanceFromPlayer = transform.position.z;
	}

	void FixedUpdate ()
	{
		/*
		transform.position = new Vector3(Mathf.Lerp(transform.position.x, player.position.x, lerpSpeed/2), transform.position.y, 
			Mathf.Lerp(transform.position.z, player.position.z + distanceFromPlayer, lerpSpeed) );
			*/
		
		transform.position = new Vector3(Mathf.Lerp(transform.position.x, player.position.x, lerpSpeed), transform.position.y, 
			transform.position.z );
		
	}
}
