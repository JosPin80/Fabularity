using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MainDistributive
{
    public class Drop : MonoBehaviour
    {
        public int numDrop;
        public void OnTriggerEnter(Collider other)
        {
            if (this.numDrop == 1)
            {
                VirtualInputManager.Instance.Drop1 = true;
                print('1');
                print(VirtualInputManager.Instance.Drop1);
                Destroy(gameObject);
            }

            if (this.numDrop == 2)
            {
                VirtualInputManager.Instance.Drop2 = true;
                print('2');
                print(VirtualInputManager.Instance.Drop2);
                Destroy(gameObject);
            }

            if (this.numDrop == 3)
            {
                VirtualInputManager.Instance.Drop3 = true;
                print('3');
                print(VirtualInputManager.Instance.Drop3);
                Destroy(gameObject);
            }

            Destroy(gameObject);
        }
    }

}