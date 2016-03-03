using UnityEngine;
using System.Collections;

public class Worm : MonoBehaviour
{
    public int wormSpeed;
    public bool detectPlayer;
    public Transform playerPawn;

    void Start()
    {

    }

    void Update()
    {
        Vector3 playerPos = GameObject.Find( "Player" ).transform.position;
        if( playerPos.y < 0.6 )
        {
            detectPlayer = true;
        }

        if( playerPos.y > 0.6 )
        {
            detectPlayer = false;
        }

        if( detectPlayer == true )
        {
            float step = wormSpeed * Time.deltaTime;
            transform.position = Vector3.MoveTowards( transform.position, playerPawn.position, step );
        }
    }
}
