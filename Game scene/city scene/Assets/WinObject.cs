using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//GetComponent<Timer>().Finish();

public class WinObject : MonoBehaviour
{

   private void OnTriggerEnter (Collider other)
   {
     GameObject.Find("TimeCanvas").GetComponent<Timer>().Finish();
      //GameObject.FindGameObjectWithTag("Player").BroadcastMessage("Finish");\
    

   }
}
