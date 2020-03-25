using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody playerRigidBody;
    public float forceMultiplier;
    public float gravityMultiplier;
    public bool onGround = true;
    public bool gameOver = false;
    

    void Start()
    {
       playerRigidBody = GetComponent<Rigidbody>();
       Physics.gravity *= gravityMultiplier;
    }   

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && onGround)
        {
            playerRigidBody.AddForce(Vector3.up * forceMultiplier, ForceMode.Impulse);
            onGround = false;
        }
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        // Game over if player hits obsticle. (set onGroundstate to true if we hit ground)
        if (collision.gameObject.CompareTag("Obsticale"))
        {
            gameOver = true;
            Debug.Log("Game Over");
        }
        else if (collision.gameObject.CompareTag("Ground"))
        {
            onGround = true;
        }
    }
}

    