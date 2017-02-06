using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flyer : Item {

	Vector3 position;
	Vector3 currentSpeed = new Vector3(5, 0);
	float timeToHide = 0.2f;

	public override void Start()
	{
		base.Start();
		rb.isKinematic = true;
		position = transform.position;
		position.y = position.y + 1;
	}

	public override void FixedUpdate()
	{
		if (rb.velocity.magnitude <= 0.1f)
		{
			currentSpeed.x *= -1;
			rb.velocity = new Vector3(currentSpeed.x, rb.velocity.y);
		}
		else
		{
			rb.velocity = new Vector3(currentSpeed.x, rb.velocity.y);
		}
	}

	public override void PickUpItem(PlayerController player)
	{
		player.slowed = true;
		player.Slow();
		Destroy(gameObject);
	}
}
