using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Movement : MonoBehaviour
{
    
    public float speed = 2;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    { 
     
    
            float xInput = Input.GetAxis ("Horizontal");

        transform.Translate(speed * Time.deltaTime * xInput, 0, 0);


      
   
           

  

 }
}
