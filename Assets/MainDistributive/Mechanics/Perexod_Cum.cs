using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
namespace MainDistributive
{
    public class Perexod_Cum : MonoBehaviour
    {
        [SerializeField] private CinemachineVirtualCamera[] VirtualCameras;
        private int currentCameraInsdex;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(KeyCode.E))
            {
                SwitchCamera();
            }
        }
        private void SwitchCamera()
        {
            VirtualCameras[currentCameraInsdex].gameObject.SetActive(false);
            currentCameraInsdex++;
            if (currentCameraInsdex >= VirtualCameras.Length)
                currentCameraInsdex = 0;
            VirtualCameras[currentCameraInsdex].gameObject.SetActive(true);
        }
    }
}

