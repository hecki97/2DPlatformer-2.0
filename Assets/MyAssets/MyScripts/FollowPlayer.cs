﻿using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour
{
	public Vector3 offset;			// The offset at which the Health Bar follows the player.
	private Transform player;		// Reference to the player.
	private PlayerHealthBar playerHealth;		// Reference to the PlayerControl script.

	void Awake ()
	{
		// Setting up the reference.
		player = GameObject.FindGameObjectWithTag("Player").transform;
		playerHealth = GetComponent<PlayerHealthBar>();
	}
	
	void Update ()
	{
			// Set the position to the player's position with the offset.
			transform.position = player.position + offset;
	}
}