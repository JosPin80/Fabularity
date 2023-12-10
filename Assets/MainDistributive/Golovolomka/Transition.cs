using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Golovolomka
{
    
    public class Transition : MonoBehaviour
    {
     
        void OnTriggerStay(Collider other)
        {
            if (other.gameObject.tag == "x1y1")
            {
                this.gameObject.transform.position = other.transform.position;
            }
            if (other.gameObject.tag == "x2y1")
            {
                this.gameObject.transform.position = other.transform.position;
            }
            if (other.gameObject.tag == "x3y1")
            {
                this.gameObject.transform.position = other.transform.position;
            }
            if (other.gameObject.tag == "x1y2")
            {
                this.gameObject.transform.position = other.transform.position;
            }
            if (other.gameObject.tag == "x2y2")
            {
                this.gameObject.transform.position = other.transform.position;
            }
            if (other.gameObject.tag == "x3y2")
            {
                this.gameObject.transform.position = other.transform.position;
            }
            if (other.gameObject.tag == "x1y3")
            {
                this.gameObject.transform.position = other.transform.position;
            }
            if (other.gameObject.tag == "x2y3")
            {
                this.gameObject.transform.position = other.transform.position;
            }
            if (other.gameObject.tag == "x3y3")
            {
                this.gameObject.transform.position = other.transform.position;
            }
        }

    }
}

