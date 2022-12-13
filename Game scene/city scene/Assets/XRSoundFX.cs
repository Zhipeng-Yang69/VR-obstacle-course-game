/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XRSoundFX : MonoBehaviour
{
    private Rigidbody _body;
    public AudioSource playSound;
    float old_posx;
    float old_posz;
    float new_posx;
     float new_posz;
    private float distToGround;
    


    //private bool IsGrounded => Physics.Raycast(
       // new Vector2(transform.position.x, transform.position.y + 2f),
       // Vector3.down, 2f);
      private bool IsGrounded =>  Physics.Raycast(transform.position, -Vector3.up, distToGround + .001f);
    

        

    // Start is called before the first frame update
    void Start()
    {
        distToGround = GetComponent<Collider>().bounds.extents.y;

        //old_posx = transform.position;
        new_posx=GetComponent<Collider>().bounds.extents.x;
        old_posx=GetComponent<Collider>().bounds.extents.x;
        old_posz=GetComponent<Collider>().bounds.extents.z;
        new_posx=GetComponent<Collider>().bounds.extents.x;
    
        //old_posy = transform.position.y;
        
    }

    // Update is called once per frame
    void Update()
    {
        old_posx =GetComponent<Collider>().bounds.extents.x;
        old_posz =GetComponent<Collider>().bounds.extents.z;
        
        checkMovement(old_posx, old_posz);

       // new_posx =  transform.position;
       new_posx=GetComponent<Collider>().bounds.extents.x;
        new_posx=GetComponent<Collider>().bounds.extents.x;
    }
    private void checkMovement(float old_posx, float old_posy)
    {
        if((old_posx != new_posx) &&( old_posz !=new_posz)&& (IsGrounded)) {
            playSound.Play();
        }
        else {
            playSound.Pause();
        }
    }
}*/
