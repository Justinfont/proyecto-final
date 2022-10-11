using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stairs : MonoBehaviour
{

    [SerializeField]
    public Transform stairlocation;
    public AudioSource stairssound;

    public GameObject[] changecamera;
    public float cooldown;     
    // Start is called before the first frame update
    void Start()
    {
    cooldown = 1;    
    }

    // Update is called once per frame
    void Update()
    {

    if(cooldown < -1){cooldown -= Time.deltaTime;}
    
    }

    private void OnTriggerStay(Collider other) {
        if(other.CompareTag("player"))
        {if (Input.GetKey(KeyCode.E) || (cooldown < 0))
        {
        other.transform.position = stairlocation.position;
        changecamera[0].SetActive(true);
        changecamera[1].SetActive(false);
        stairssound.Play();
        cooldown = 3;
        }

        }
    }
}
