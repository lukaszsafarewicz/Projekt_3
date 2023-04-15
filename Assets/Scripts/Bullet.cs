using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
	Rigidbody rb;
	float force = 50;
	
	
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
	rb.AddForce(transform.forward*force, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("Box"))
		{
		Destroy(collision.gameObject);
		}
	}


}
