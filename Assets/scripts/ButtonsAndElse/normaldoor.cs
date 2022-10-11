using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class normaldoor : MonoBehaviour
{
    [SerializeField]
    [Range(-1f,1f)]
    //public float distancetowall;
    public bool open;
    public AudioSource opendoor; 
    private void OnTriggerStay(Collider other) {
     if ( Input.GetKey(KeyCode.E))
    { 
      if(open == false){
    transform.position = transform.position + new Vector3(0,10f,0f);
    //transform.Rotate(0,-90,0);
    opendoor.Play();
    open = true;
      }
    } 
    }
    
}
