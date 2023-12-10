using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MainDistributive
{
    public class KeyboardInput : MonoBehaviour
    {
        //Условие запустка передвижений
        void Update()
        {
       
            if (Input.GetKeyDown(KeyCode.Space))
            {
                VirtualInputManager.Instance.Jump = true;
            }
            else
            {
                VirtualInputManager.Instance.Jump = false;
            }

            if (Input.GetKeyUp(KeyCode.F))
            {
                VirtualInputManager.Instance.Take = true;
            }
            else
            {
                VirtualInputManager.Instance.Take = false;
            }

            if (Input.GetKey(KeyCode.D))
            {
                VirtualInputManager.Instance.MoveRight = true;
            }
            else
            {
                VirtualInputManager.Instance.MoveRight = false;
            }
            //Здесь настроить
            if (Input.GetKey(KeyCode.LeftShift))
            {
                VirtualInputManager.Instance.MoveLeftShift = true;
            }
            else
            {
                VirtualInputManager.Instance.MoveLeftShift = false;
            }

            if (Input.GetKey(KeyCode.A))
            {
                VirtualInputManager.Instance.MoveLeft = true;
            }
            else
            {
                VirtualInputManager.Instance.MoveLeft = false;
            }
            

        }
    }
}
