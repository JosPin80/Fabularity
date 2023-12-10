using Golovolomka;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Golovolomka
{
    public class Task : MonoBehaviour
    {
        public static Task Instance = null;

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
        public bool task = false;
        void OnTriggerStay(Collider other)
        {
            if (other.gameObject.tag == "Truba_Povorot")
            {
                if (this.gameObject.transform.rotation == other.transform.rotation && this.gameObject.transform.position == other.gameObject.transform.position)
                {
                    print("stay");
                    task = true;
                }
                else
                {
                    task = false;
                    return;
                }
                
            }
        }
    }
}


