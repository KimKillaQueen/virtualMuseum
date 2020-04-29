using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnwheel_script : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float turnSpeed = 25.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime, Space.World);
    }
}
