using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changecamera : MonoBehaviour
{

    public bool changedcamera = true;
    public GameObject[] cameras;
    // Start is called before the first frame update
    void Start()
    {
        changedcamera = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
      private void OnTriggerEnter(Collider other)
      {
        if (changedcamera == false)
        {
         cameras[0].SetActive(true);
         cameras[1].SetActive(false); 
         changedcamera = true; 
         Debug.Log("camara1");
         
        
        }
        else
        {
        cameras[0].SetActive(false);
        cameras[1].SetActive(true);
        changedcamera = false;
        Debug.Log("camara2");

        }
    }


  
}
