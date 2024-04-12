//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Movement : MonoBehaviour
//{

//   public float speed = 10f;
//   public float rotateSpeed = 10f;

//  private Vector3 movement;
//    private float rotation;

//   void Update()
//    {
//      movement.z = Input.GetAxis("Vertical") * speed * Time.deltaTime;
//        rotation = Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime;
//    }

////    void FixedUpdate()
////    {
////        transform.Translate(movement, Space.Self);
////        transform.Rotate(0f, rotation, 0f);
////    }

////}
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10f;
public float rotateSpeed = 10f;

private void Update()
{
    float horizontalInput = Input.GetAxis("Horizontal");
    float verticalInput = Input.GetAxis("Vertical");


    float rotation = horizontalInput * rotateSpeed * Time.deltaTime;
    transform.Rotate(0f, rotation, 0f);

    Vector3 movement = transform.forward * verticalInput * speed * Time.deltaTime;


    float playerSize = 0.7f;
    bool canMove = !Physics.Raycast(transform.position, movement.normalized, playerSize);

    if (canMove)
    {
        transform.Translate(movement, Space.World);
    }
}
}