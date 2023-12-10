using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Cinemachine;
namespace MainDistributive
{
    public class Perexod_Scene : MonoBehaviour
    {
        public float x;
        public float y;
        public float z;
        public GameObject cum;
        public void Transition()
        {
            transform.position = new Vector3(x, y, z);
            transform.rotation = Quaternion.Euler(0,180,0);
        }
    }
}



