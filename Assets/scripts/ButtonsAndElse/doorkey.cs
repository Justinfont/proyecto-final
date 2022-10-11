using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorkey : MonoBehaviour
{

    public AudioSource opendoor;
    public bool canopendoor;
    Renderer rend;
    public Material[] TypeOfKey;
    enum types  {NormalkeyDoors, RedKeyDoors , BlueKeydoors};

    [SerializeField] types Keytype;

public  GameObject doorthatneedskey;

    // Start is called before the first frame update
    void Start()
    {
     rend = GetComponent<Renderer>();
     rend.enabled = true; 
     canopendoor = false;  
    }

    // Update is called once per frame
    void Update()
    {   
    switch(Keytype)
        {
            case types.NormalkeyDoors:
            Normalkey();
            break;

            case types.RedKeyDoors:
            RKey();
            break;

            case types.BlueKeydoors:
            Bkey();
            break;

    }
    }


 public  void Normalkey()
{
        rend.sharedMaterial = TypeOfKey[0];
         if (Input.GetKey(KeyCode.E) && (canopendoor == true)) {
        if (itemmanager.Key > 0)
            {
                doorthatneedskey.transform.position = doorthatneedskey.transform.position + Vector3.up * 9 ;
                transform.position += Vector3.up * 9;
                itemmanager.Key--;
                //HudManager.instance.SetSelectedText(itemmanager.Key.ToString()); 
                opendoor.Play();
            }
        else
            {
           Debug.Log("no keys");  
            }
}
}

public  void RKey()
    {
        rend.sharedMaterial = TypeOfKey[1]; 
        if (Input.GetKey(KeyCode.E) && (canopendoor == true)) {
        
         if (itemmanager.RedKey > 0)
            {
                doorthatneedskey.transform.position = doorthatneedskey.transform.position + Vector3.up * 9 ;
                transform.position += Vector3.up * 9;
                opendoor.Play(); 
            }
            }
    }

public void Bkey()
{
 rend.sharedMaterial = TypeOfKey[2]; 
        if (Input.GetKey(KeyCode.E) && (canopendoor == true)) {
        
         if (itemmanager.bluekey > 0)
            {
                doorthatneedskey.transform.position = doorthatneedskey.transform.position + Vector3.up * 9 ;
                transform.position += Vector3.up * 9;
                opendoor.Play(); 
            }
            }

}




private void OnTriggerStay(Collider other) {
if (other.CompareTag("player")){
    canopendoor = true;
}
}

private void OnTriggerExit(Collider other) {
    if (other.CompareTag("player")){
 canopendoor = false;   
}}


}

