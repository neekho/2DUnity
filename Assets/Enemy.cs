using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float movementSpeed;

    public float distanceFromCenter;

    private Vector3 leftTargetPosition;

    private Vector3 rightTargePosition;

    private Vector3 targetPosition;

    private float distanceFromTarget;

    public bool goingRight;


    // Start is called before the first frame update
    void Start()
    {
        leftTargetPosition = this.transform.position - (Vector3.right * distanceFromCenter);
        rightTargePosition = this.transform.position + (Vector3.right * distanceFromCenter);
    }

    // Update is called once per frame
    void Update()
    {
        if (goingRight)
            targetPosition = rightTargePosition;
        else
            targetPosition = leftTargetPosition;


        distanceFromTarget = Vector3.Distance(this.transform.position, targetPosition);


        if (distanceFromTarget > 0.1f) {
            this.transform.position = Vector3.MoveTowards(this.transform.position, targetPosition, 
            movementSpeed * Time.fixedDeltaTime);
        }

        else{

            
            
            goingRight = !goingRight;
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
        }
           

    }


    //  void OnCollisionEnter2D(Collision2D col) {
    //     if(col.transform.tag == "Player") {
           

    //         Debug.Log("deads enemy");
    //         Destroy(col.gameObject);

    //     }
    // }
}