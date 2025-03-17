using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BallModifiers : MonoBehaviour
{

   
{
    public Color ColorElement;
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.CompareTag("Ball"))
        {
            GetComponent<ScaleMode>().scale = 5;
            GetComponent<ModifiableMassProperties>().mass.value = 5;
            GetComponent<Material>().material.color = ColorElement;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            GetComponent<ScaleMode>().scale = 1;
            GetComponent<ModifiableMassProperties>().mass.value = 1;
            GetComponent<Material>().material.color = ColorElement;
        }
    }

    void Start()
    {
        
    }

 
    void Update()
    {
        
    }
}
