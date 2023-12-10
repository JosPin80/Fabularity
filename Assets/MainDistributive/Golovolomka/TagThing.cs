using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MainDistributive;

public class TagThing : MonoBehaviour
{
    public int resObject;
    public float x;
    public float y;
    public float z;
    private bool tiket = false;
    void Update()
    {
        if (!tiket)
        {
            if (VirtualInputManager.Instance.Drop1 && resObject == 1)
            {
                this.gameObject.transform.position = new Vector3(x, y, z);
                tiket = true;
            }
        }

        if (!tiket)
        {
            if (VirtualInputManager.Instance.Drop2 && resObject == 2)
            {
                this.gameObject.transform.position = new Vector3(x, y, z);
                tiket = true;
            }
        }

        if (!tiket)
        {
            if (VirtualInputManager.Instance.Drop3 && resObject == 3)
            {
                this.gameObject.transform.position = new Vector3(x, y, z);
                tiket = true;
            }
        }
    }
}
