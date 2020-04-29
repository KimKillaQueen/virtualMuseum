using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    private CharacterController playerRB;
    [SerializeField] public float moveSpeed = 3.0f;
    [SerializeField] public float rotateSpeed = 15.0f;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = Vector3.zero;

        dir.x = Input.GetAxisRaw("Horizontal");
        dir.z = Input.GetAxisRaw("Vertical");

        dir = transform.TransformDirection(dir);
        // if (dir.magnitude > 0)
        // {
        //     dir = Vector3.RotateTowards(dir, transform.forward, 2, 2);
        // }

        playerRB.Move(dir * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.Q))
        {
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles - rotateSpeed * Vector3.up * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.E))
        {
            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + rotateSpeed * Vector3.up * Time.deltaTime);
        }
    }
}
