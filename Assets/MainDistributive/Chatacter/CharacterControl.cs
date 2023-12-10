using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

namespace MainDistributive
{
    public class CharacterControl : MonoBehaviour
    {
        //Вызов Анимации (её список)
        public enum TransitionParameter
        {
            Move,
            Runing,
            RunnigJump
        }
        //Вызываемые переменные
        public float Speed;
        public float Speed2x;
        public float jumpSpeed = 8.0F;
        public float gravity = 20.0F;
        private Vector3 moveDirection = Vector3.zero;
        public Animator animator;
        void Update()
        {
            {
                CharacterController controller = GetComponent<CharacterController>();
                if (controller.isGrounded)
                {
                    if (VirtualInputManager.Instance.Jump)
                        moveDirection.y = jumpSpeed;
                        
                }
                //SetBool(TransitionParameter.RunnigJump.ToString(), true);
                moveDirection.y -= gravity * Time.deltaTime;
                controller.Move(moveDirection * Time.deltaTime);
            }

            

            //прыжок
            if (VirtualInputManager.Instance.Jump)
            {
                animator.SetBool(TransitionParameter.RunnigJump.ToString(), true);
            }
            else if (!VirtualInputManager.Instance.Jump)
            {
                animator.SetBool(TransitionParameter.RunnigJump.ToString(), false);
            }

            //Условия для остановки (ничего не начато)
            if (!VirtualInputManager.Instance.MoveRight && !VirtualInputManager.Instance.MoveLeft)
            {
                animator.SetBool(TransitionParameter.Move.ToString(), false);
                if (!VirtualInputManager.Instance.MoveLeftShift)
                {
                    animator.SetBool(TransitionParameter.Runing.ToString(), false);
                }
                else if (VirtualInputManager.Instance.MoveLeftShift)
                {
                    animator.SetBool(TransitionParameter.Runing.ToString(), false);
                }
            }   
            //Условия для остановки (все начаты)
            if (VirtualInputManager.Instance.MoveRight && VirtualInputManager.Instance.MoveLeft)
            {
                animator.SetBool(TransitionParameter.Move.ToString(), false);
                if (VirtualInputManager.Instance.MoveLeftShift)
                {
                    animator.SetBool(TransitionParameter.Runing.ToString(), false);
                }
            }
            //Услови передвижение Вправо
            if (VirtualInputManager.Instance.MoveRight)
            {
                this.gameObject.transform.Translate(Vector3.forward * Speed * Time.deltaTime);
                this.gameObject.transform.rotation = Quaternion.Euler(0f,0f,0f);
                animator.SetBool(TransitionParameter.Move.ToString(), true);
                if (VirtualInputManager.Instance.Jump)
                {
                    animator.SetBool(TransitionParameter.RunnigJump.ToString(), true);
                }
                else if (!VirtualInputManager.Instance.Jump)
                {
                    animator.SetBool(TransitionParameter.RunnigJump.ToString(), false);
                }

                //Условие SpeedMove движение 
                if (VirtualInputManager.Instance.MoveLeftShift)
                {
                    this.gameObject.transform.Translate(Vector3.forward * Speed2x * Time.deltaTime);
                    animator.SetBool(TransitionParameter.Runing.ToString(), true);

                }
                //И когда он прекращает онимацию бега
                else if (!VirtualInputManager.Instance.MoveLeftShift)
                {
                   animator.SetBool(TransitionParameter.Runing.ToString(), false);
                }
            }
            //Услови передвижение Влево
            if (VirtualInputManager.Instance.MoveLeft)
            {
                this.gameObject.transform.Translate(Vector3.forward * Speed * Time.deltaTime);
                this.gameObject.transform.rotation = Quaternion.Euler(0f, 180f, 0f);
                animator.SetBool(TransitionParameter.Move.ToString(), true);
                //Условие SpeedMove движение 
                if (VirtualInputManager.Instance.Jump)
                {
                    animator.SetBool(TransitionParameter.RunnigJump.ToString(), true);
                }
                else if (!VirtualInputManager.Instance.Jump)
                {
                    animator.SetBool(TransitionParameter.RunnigJump.ToString(), false);
                }
                if (VirtualInputManager.Instance.MoveLeftShift)
                {
                    this.gameObject.transform.Translate(Vector3.forward * Speed2x * Time.deltaTime);
                    animator.SetBool(TransitionParameter.Runing.ToString(), true);
                }
                //И когда он прекращает онимацию бега
                else if (!VirtualInputManager.Instance.MoveLeftShift)
                {
                    animator.SetBool(TransitionParameter.Runing.ToString(), false);
                }
            
            }
        }
    }
}
