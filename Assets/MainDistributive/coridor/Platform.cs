using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MainDistributive;

public class Platform : MonoBehaviour
{
    private bool trig = true;
    public float Speed = 2;
    
    
    // Update is called once per frame
    void Update()
    {
        if (trig)
        {
            this.gameObject.transform.Translate(-Vector3.forward * Speed * Time.deltaTime); 
            if (this.transform.position.z < -8)
            {
                trig = false;
            }
        }
        else if (!trig)
        {
            this.gameObject.transform.Translate(Vector3.forward * Speed * Time.deltaTime);
            if (this.transform.position.z > -4)
            {
                trig = true;
            }
        }
    }
}
