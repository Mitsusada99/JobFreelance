using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tv : MonoBehaviour
{
    public GameObject objdialogo;    
    private bool isTrigger;
    void Start()
    {
        
    }

    void Update()
    {
        if(isTrigger)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
               objdialogo.SetActive(true);
            }
        }
    }

   void OnTriggerStay2D (Collider2D other)
   {
       if(other.gameObject.CompareTag("Player"))
       {
           isTrigger = true;
       }
   }

   void OnTriggerExit2D (Collider2D other)
   {
       if(other.gameObject.CompareTag("Player"))
       {
           isTrigger = false;
           objdialogo.SetActive(false);
       }
   }



}
