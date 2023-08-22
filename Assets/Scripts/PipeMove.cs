using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
   [SerializeField] public float pipeSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * pipeSpeed * Time.deltaTime; 
    }
}
