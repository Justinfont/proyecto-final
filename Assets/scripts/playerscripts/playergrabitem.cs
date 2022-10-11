using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playergrabitem : MonoBehaviour
{

  public GameObject[] ItemHud;
     public AudioSource grabkey;
  private void OnTriggerStay(Collider other) {
  if (other.CompareTag("key")){if (Input.GetKey(KeyCode.E))
    {
    itemmanager.Key++;
    other.gameObject.SetActive(false);
    grabkey.Play();
    ItemHud[0].SetActive(true);
    ItemHud[1].SetActive(true);
    //HudManager.instance.SetSelectedText(itemmanager.Key.ToString());  
    }  
  }
  


   if (other.CompareTag("KeyRed")){if (Input.GetKey(KeyCode.E))
    {
    itemmanager.RedKey++;
    other.gameObject.SetActive(false);
    grabkey.Play();
    ItemHud[2].SetActive(true);


  
    }
}

if (other.CompareTag("lantern")){if (Input.GetKey(KeyCode.E))
    {
    itemmanager.lanternobtained = true;
    other.gameObject.SetActive(false);
    Debug.Log("lantern obtained");
     ItemHud[3].SetActive(true);
     ItemHud[4].SetActive(true);
     


  
    }
}
}
}