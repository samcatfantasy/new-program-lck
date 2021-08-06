using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addforce_try : MonoBehaviour
{   
    // Start is called before the first frame update
    public Rigidbody rigid;
    void Start()
    {
        rigid.useGravity = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        rigid.AddForce(0, 0, 200*Time.deltaTime);
    }
}
