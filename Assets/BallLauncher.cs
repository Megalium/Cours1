using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLauncher : MonoBehaviour
{
    public GameObject Ball;
    public float speedRotation;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Instantiate(Ball, transform.position, transform.rotation);

            float horizontalInput = Input.GetAxis("Horizontal");
            Debug.Log(horizontalInput);
            transform.Rotate(0f, 0f, horizontalInput * speedRotation * Time.deltaTime);
        }
    }
}
