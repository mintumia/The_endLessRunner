using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayerController : MonoBehaviour
{

    CharacterController mainCharacter;
    private float Speed = 5f;
    private int rotateAngle = 90;
    private float JumpHeight = 50f;
    private float gravityValue = -9.81f;
    private bool PlayerGrounded = false;
    private Vector3 PlayerVelocity;


    // Start is called before the first frame update
    private void Awake()
    {
        mainCharacter = GetComponent<CharacterController>();
    }

    void Start()
    {
       // Debug.Log("Hello World");
        
    }

    // Update is called once per frame
    void Update()
    {
        MovementHandler();


    }
    private void FixedUpdate()
    {

       
        

    }




    public void MovementHandler()
    {
       Jump();

        mainCharacter.transform.Translate(Vector3.forward * Speed * Time.deltaTime);

        


        if (Input.GetKeyDown(KeyCode.RightArrow))
        {

            mainCharacter.transform.Rotate(mainCharacter.transform.rotation.x,mainCharacter.transform.rotation.y + rotateAngle, mainCharacter.transform.rotation.z, Space.World);
            
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("Rotate");
            mainCharacter.transform.Rotate(mainCharacter.transform.rotation.x, mainCharacter.transform.rotation.y - rotateAngle, mainCharacter.transform.rotation.z, Space.World);

        }
       

       // mainCharacter.Move(new Vector3 (0))
       


    }

    public void Jump()
    {
        PlayerGrounded = mainCharacter.isGrounded;

        if ( PlayerGrounded && Input.GetButton("Jump"))
        {

            Debug.Log("Jump");

           // mainCharacter.jump


            PlayerGrounded = false;

        }



    }










}
