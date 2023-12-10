using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golovolomka
{
    public class Transition_Mouse : MonoBehaviour
    {
        /*private Transform angle;
        private void Start()
        {
            angle = GetComponent<Transform>();
        }*/
        Vector3 mousePosition;
        public float angle = 0;

        private Vector3 GetMousePos()
        {
            return Camera.main.WorldToScreenPoint(transform.position);
        }

        private void OnMouseDown()
        {
            mousePosition = Input.mousePosition - GetMousePos();
        }   

        private void OnMouseDrag()
        {
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition - mousePosition);
            if (Input.GetKeyDown(KeyCode.E))
            {
                angle += 90;
                this.gameObject.transform.rotation = Quaternion.Euler(0, 0, angle);
                if (angle >= 360)
                {
                    angle = 0;
                }
            }
            
        }
    }
}

