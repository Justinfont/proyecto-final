using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlotOfKeysDoor : MonoBehaviour
{
public GameObject[] keymodels;
public AudioSource dooropen;
public AudioSource Keyused;
public float keyrequired;
public bool keyused1;
public bool keyused2;
public bool keyused3;
public bool keyused4;

    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
   
    }


private void OnTriggerStay(Collider other) 
{
if  (Input.GetKeyDown(KeyCode.E)) 
{
if (itemmanager.Key > 0)
{
 if (keyused1 == false)
 {keymodels[0].SetActive(true);
 keyused1 = true;
 Keyused.Play();
 itemmanager.Key--;}
 else
    {
    if (keyused2 == false)
    {
    keymodels[1].SetActive(true);
    keyused2 = true;
    Keyused.Play(); 
    itemmanager.Key--; 
    }
    else
    {
    if (keyused3 == false)
    {
    keymodels[2].SetActive(true);
    keyused3 = true;
    Keyused.Play();
    itemmanager.Key--;
    }
    else
        {if (keyused4 == false)
        {
        keymodels[3].SetActive(true);
        keyused4 = true;
        Keyused.Play();
        itemmanager.Key--;
        }
        }    
    }
    }   
 }

if ((keyused1 == true) && (keyused2 == true) && ( keyused3 == true) && (keyused4 == true))
{
transform.position = transform.position + Vector3.up * 9;  
dooropen.Play();   
}
}


}



}



