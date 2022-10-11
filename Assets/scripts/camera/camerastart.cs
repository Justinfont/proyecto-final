using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerastart : MonoBehaviour
{
    public GameObject[] cameras;
    // Start is called before the first frame update
    void Start()
    {
    cameras[0].SetActive(true);
    cameras[1].SetActive(false);
    cameras[2].SetActive(false);
    cameras[3].SetActive(false);
    //cameras[4].SetActive(false);
    //cameras[5].SetActive(false);
    //cameras[6].SetActive(false);
    //cameras[7].SetActive(false);
    //cameras[8].SetActive(false);
    //cameras[9].SetActive(false);
    //cameras[10].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
