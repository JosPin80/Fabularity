using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MainDistributive
{
    //Список переменных
    public class VirtualInputManager : Singleton<VirtualInputManager>
    {
        public bool MoveRight;
        public bool MoveLeft;
        public bool MoveLeftShift;
        public bool Jump;
        public bool Take;
        public bool Drop1 = false;
        public bool Drop2 = false;
        public bool Drop3 = false;
        /*
        private Rigidbody rigid;
        public Rigidbody RIGID
        {
            get
            {
                if (rigid == null)
                {
                    rigid = GetComponent<Rigidbody>();
                }
                return rigid;
            }
        }
        */
    }
}
