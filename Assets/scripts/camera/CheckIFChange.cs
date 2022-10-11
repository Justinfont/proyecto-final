using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckIFChange : MonoBehaviour
{
public GameObject[] Cameras;

private void OnTriggerEnter(Collider other) 
{
  if (Cameras[0].activeInHierarchy == false )
  {
    Cameras[0].SetActive(true);
    Cameras[1].SetActive(false); 
  }  

}

}
