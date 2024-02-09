using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;

    public Animator animator; 

    public Animator animatorExample;


    public float runSpeed = 40f;

    float horizontalMove = 0f;

    bool jump = false;




    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("SPEED", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump")) {
            jump = true;
        }
    }

    void FixedUpdate()
    {

        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }

    void OnTriggerEnter2D(Collider2D col) {
        if(col.transform.tag == "Barrel" || col.transform.tag == "Enemy") {
            ScoreManager.instance.addScore();
        
            Destroy(col.gameObject);
        }

      
    }

    void OnCollisionEnter2D(Collision2D col) {
        if (col.transform.tag == "Enemy" || col.transform.tag == "bullet") {

            // ManagerGame.instance.onGameOver();
            
            ManageScenes.instance.reloadScene();
            ScoreManager.instance.resetScore();
        }
    }
}
