using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
namespace MainDistributive
{
    public class CameraTransition : MonoBehaviour
    {
        public GameObject cum;
        
        void Update()
        {
            if (Input.GetKey(KeyCode.E))
            {
                transform.position = new Vector3(0, 0, 0);
            }
        }
    }
}
