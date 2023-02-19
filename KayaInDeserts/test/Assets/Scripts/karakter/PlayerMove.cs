using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMove : MonoBehaviour
{
    public float kosuHizi = 5;
    public float sagSolHizi = 4;

    public Animator animasyon;
    public Rigidbody rigi ;
    private CharacterController controller;

    void Update()
    {   

        

        transform.Translate(Vector3.forward * Time.deltaTime * kosuHizi, Space.World);
        
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){
            if(this.gameObject.transform.position.x > SeviyeSiniri.leftSide)
            {
                 transform.Translate(Vector3.left* Time.deltaTime* sagSolHizi);
            }
        }
         if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){

            if(this.gameObject.transform.position.x < SeviyeSiniri.rightSide)
            {
                transform.Translate(Vector3.left* Time.deltaTime* sagSolHizi* -1);
            }

        }
        if(Input.GetKey(KeyCode.Space)){
            
            if(this.gameObject.transform.position.y < 3)
            {
                 transform.Translate(Vector3.up* Time.deltaTime*42);
            }
        }
        //controller.center = controller.center;
    }

        /*if(this.transform.position.x <=3)
        {
             this.rigi.velocity = Vector3.zero;
        }
        else
        {
            this.rigi.AddForce(0,0,0);
        }*/

    private void OnCollisionEnter(Collision collision) 
    {
        if (collision.gameObject.tag=="engel"){
            Debug.Log("Çarptı");
            GameOver.gameOver = true; 
        }
        
    }
    /*private void OnControllerColliderHit(ControllerColliderHit hit) {
        if(hit.transform.tag=="engel")
        {
            GameOver.gameOver = true;   
        }
    }*/
    
}
