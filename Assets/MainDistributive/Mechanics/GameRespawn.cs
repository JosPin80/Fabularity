using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class GameRespawn : MonoBehaviour
{
    public float theshold;
    public float x;
    public float y;
    public float z;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position.y < theshold)
        {
            transform.position = new Vector3(x, y, z);
        }
    }
}
