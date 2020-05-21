using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Animator myAnim;
    // Start is called before the first frame update
    void Start()
    {
        myAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        myAnim.SetInteger("MoveState", 0); //Idle/StopWalking


        if (Input.GetKey(KeyCode.UpArrow))
        {
            myAnim.SetInteger("MoveState", 1); //Movement
        }

        if (Input.GetKey(KeyCode.X))
        {
            myAnim.SetInteger("MoveState", 10); //Sword Slash
        }
        if (Input.GetKey(KeyCode.UpArrow) && (Input.GetKey(KeyCode.LeftShift))) //Running
            {
            myAnim.SetInteger("MoveState", 2);
        } 
        if (Input.GetKey(KeyCode.A)) //Jump
        {
            myAnim.SetInteger("MoveState", 3);
        }
        if (Input.GetKey(KeyCode.J)) //Jump+Flip
        {
            myAnim.SetInteger("MoveState", 4);
        }
        if (Input.GetKey(KeyCode.RightArrow))//Right Turn
        {
            myAnim.SetInteger("MoveState", 5);
        }
        if (Input.GetKey(KeyCode.LeftArrow))//Left Turn
        {
            myAnim.SetInteger("MoveState", 6);
        }






    }
}
