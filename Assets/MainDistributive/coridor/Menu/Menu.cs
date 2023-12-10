using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MainDistributive;

public class Menu : MonoBehaviour
{
    public Camera Camera;
    public GameObject F;
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "player")
        {
            F.transform.localPosition = new Vector3(-0.317f, -0.231f, 0.374f);
            if (Input.GetKeyDown(KeyCode.F))
            {
                Camera.transform.localPosition = new Vector3(0, 0, 0);
                Camera.transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
            }
        }
    }
}
