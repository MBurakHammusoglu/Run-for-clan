using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] int movementSpeed=5;

    void Update()
    {
      Movement();
    }

    void Movement(){
        float movementX = Input.GetAxis("Horizontal");
        float movementZ = Input.GetAxis("Vertical");

        Vector3 movementPosition = new Vector3 (movementX,0f,movementZ);
        
        transform.Translate(movementPosition * Time.deltaTime * movementSpeed);


    }
}
