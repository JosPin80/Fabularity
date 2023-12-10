using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golovolomka
{
    public class Task2 : MonoBehaviour
    {
        public static Task2 Instance = null;

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
        public bool task2 = false;
        void OnTriggerStay(Collider other)
        {
            if (other.gameObject.tag == "Truba_Povorot")
            {
                if (this.gameObject.transform.rotation == other.transform.rotation && this.gameObject.transform.position == other.gameObject.transform.position)
                {
                    print("stay2");
                    task2 = true;
                }
                else
                {
                    task2 = false;
                    return;
                }

            }
        }
    }
}
