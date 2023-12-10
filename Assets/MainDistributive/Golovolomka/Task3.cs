using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golovolomka
{
    public class Task3 : MonoBehaviour
    {
        public static Task3 Instance = null;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            }
            else if (Instance != this)
            {
                Destroy(this.gameObject);
            }
        }
        public bool task3 = false;
        void OnTriggerStay(Collider other)
        {
            if (other.gameObject.tag == "Truba")
            {
                if (this.gameObject.transform.rotation == other.transform.rotation && this.gameObject.transform.position == other.gameObject.transform.position)
                {
                    print("stay3");
                    task3 = true;
                }
                else
                {
                    task3 = false;
                    return;
                }

            }
        }
    }
}
