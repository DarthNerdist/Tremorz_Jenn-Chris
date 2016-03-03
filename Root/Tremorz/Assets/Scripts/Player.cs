using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player : MonoBehaviour
{
    public int Hunger;
    public int Hydration;
    public int Energy;
    public int playerSpeed;
    public float jumpHeight;
    public float gravity;

    public bool isDetected = false;

    private Vector3 moveDirection = Vector3.zero;

    void Start()
    {
        
    }

    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();

        if( controller.isGrounded )
        {
            moveDirection = new Vector3( Input.GetAxis( "Horizontal1" ), 0, Input.GetAxis( "Vertical1" ) );

            moveDirection = transform.TransformDirection( moveDirection );
            moveDirection *= playerSpeed;

            if( Input.GetButton( "Jump" ) )
            {
                moveDirection.y = jumpHeight;
                isDetected = false;
            }
        }

        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move( moveDirection * Time.deltaTime );
    }
}
