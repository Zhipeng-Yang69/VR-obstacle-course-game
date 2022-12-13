using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockSoundTrigger : MonoBehaviour
{
    public AudioSource hitSound;


	void OnCollisionEnter(Collision collision)
	{
	
			//Debug.DrawRay(contact.point, contact.normal, Color.white);
			if (collision.gameObject.tag == "plane")
			{
				hitSound.Play();
				
			}
		
	

	}
}
