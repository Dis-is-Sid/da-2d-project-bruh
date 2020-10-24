using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisontwoD : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

   
    void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "spike")
		{

            Debug.Log("u ded");

        }
    }

}