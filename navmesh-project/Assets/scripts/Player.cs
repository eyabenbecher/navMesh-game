//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Player : MonoBehaviour
//{
//     [SerializeField] private float moveSpeed = 7f;
//    void Update()
//    {
//        Vector2 inputVector = new Vector2(0, 0);
//        if (Input.GetKey(KeyCode.A))
//        {
//            inputVector.y=+1; 
//        }
//        if (Input.GetKey(KeyCode.D))
//        {
//            inputVector.y = -1;
//        }
//        if (Input.GetKey(KeyCode.S))
//        {
//            inputVector.x = -1;
//        }
//        if (Input.GetKey(KeyCode.W))
//        {
//            inputVector.x = +1;
//        }
//        inputVector =inputVector.normalized;
//        Vector3 moveDir = new Vector3(inputVector.x,0,inputVector.y);

//            transform.position += moveDir * moveSpeed * Time.deltaTime;

//    }
//}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed = 10f;
    public float rotateSpeed = 10f;

    private Vector3 movement;
    private float rotation;

    void Update()
    {
        movement.z = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        rotation = Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime;
    }

    void FixedUpdate()
    {
        transform.Translate(movement, Space.Self);
        transform.Rotate(0f, rotation, 0f);
    }

}