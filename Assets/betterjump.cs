using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class betterjump : MonoBehaviour
{

    public int fallspeed = 2;
    public Rigidbody2D rb;


	void Update()
	{
		if (rb.velocity.y < 0)
		{
			rb.velocity += Vector2.up * Physics2D.gravity.y * fallspeed * Time.deltaTime;

		}
		
	}
}


		
