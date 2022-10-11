using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallbutton : MonoBehaviour
{



 public GameObject door;   
 public bool alreadyopen;   
 public AudioSource dooropen;

 public void Start() {
   alreadyopen = false; 
 }
private void OnTriggerStay(Collider other) { if ( Input.GetKey(KeyCode.E))
    { 
  if (alreadyopen == false)
        {
    door.transform.position = door.transform.position + Vector3.up * 9 ;
    dooropen.Play();
    alreadyopen = true;  
    }
}
    
}
}
