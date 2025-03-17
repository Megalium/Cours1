using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMouvement : MonoBehaviour
{
    public float speed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        Debug.Log(verticalInput);
        transform.Translate(0f, +1, 0f);
    }
}
