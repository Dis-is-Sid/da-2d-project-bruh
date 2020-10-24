using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movetodee : MonoBehaviour
{
    [SerializeField]private LayerMask platformlayer;

    public float jumpforce = 5f;
    public float movementspeed = 5f;
    public float dashforce = 3;
    public Rigidbody2D rb;
    
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        

        if (Input.GetButtonDown("Jump") && isgrounded())
		{
            rb.velocity = Vector2.up * jumpforce;
        }

        // for movement that does not suck
         Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
        transform.position += movement* Time.deltaTime * movementspeed;

        if (Input.GetKeyDown(KeyCode.LeftShift))
		{
            dash();
        }

    }
    void dash()
	{
        rb.velocity = Vector2.right * dashforce * Input.GetAxis("Horizontal");
    }

private bool isgrounded()
    {
        return Physics2D.Raycast(transform.position, Vector3.down, 1,platformlayer);
    }

}
