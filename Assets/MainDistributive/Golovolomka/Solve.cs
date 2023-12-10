using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Golovolomka
{
    public class Solve : MonoBehaviour
    {
        void Update()
        {
            if (Task.Instance.task && Task2.Instance.task2 && Task3.Instance.task3 == true)
            {
                this.gameObject.transform.position = new Vector3(0,0,0);
            }
        }
    }
}

