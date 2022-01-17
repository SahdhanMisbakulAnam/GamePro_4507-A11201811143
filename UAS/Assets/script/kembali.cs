using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kembali : MonoBehaviour
{
    // Start is called before the first frame update
    public bool back;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Escape) || (back == true)){
            Application.LoadLevel(0);
        }   
    }
}
