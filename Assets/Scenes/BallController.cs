using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {
    private Animator myAnimator;

    private Rigidbody myRigidbody;
    private float forwardForce = 800.0f;
    private float turnForce = 5000.0f;
    private float movableRange = 3.4f;

    void Start () {
        
        this.myRigidbody = GetComponent<Rigidbody>();
 
    }

    void Update () {
                
        this.myRigidbody.AddForce (this.transform.forward * this.forwardForce);
        if (Input.GetKey (KeyCode.LeftArrow)  && -this.movableRange < this.transform.position.x) {
            this.myRigidbody.AddForce (-this.turnForce, 0, 0);
        } else if (Input.GetKey (KeyCode.RightArrow)  && this.transform.position.x < this.movableRange) {
            this.myRigidbody.AddForce (this.turnForce, 0, 0);
        } 
    }
}