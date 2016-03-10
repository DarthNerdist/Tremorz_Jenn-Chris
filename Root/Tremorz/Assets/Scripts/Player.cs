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

    Animator anim;

    int jumpHash = Animator.StringToHash( "Jump" );
    /*int runStateHash = Animator.StringToHash( "Base Layer.Run" );*/

    void Start()
    {
        anim = GetComponent<Animator>();
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
                anim.SetTrigger( jumpHash );
                isDetected = false;
            }
        }

        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move( moveDirection * Time.deltaTime );

        /*float move = Input.GetAxis( "Vertical" );
        anim.SetFloat( "Speed", move );

        AnimatorStateInfo stateInfo = anim.GetCurrentAnimatorStateInfo( 0 );
        if( Input.GetKeyDown( KeyCode.Space ) && stateInfo.nameHash == runStateHash )
        {
            anim.SetTrigger( jumpHash );
        }*/
    }
}
