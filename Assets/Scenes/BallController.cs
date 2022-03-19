using UnityEngine;

public class BallController : MonoBehaviour
{
    private readonly float forwardForce = 800.0f;
    private readonly float movableRange = 18f;
    private Animator myAnimator;

    private Rigidbody myRigidbody;
    private readonly float turnForce = 5000.0f;

    private void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        myRigidbody.AddForce(transform.forward * forwardForce);
        if (Input.GetKey(KeyCode.LeftArrow) && -movableRange < transform.position.x)
            myRigidbody.AddForce(-turnForce, 0, 0);
        else if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < movableRange)
            myRigidbody.AddForce(turnForce, 0, 0);

        if (Input.GetMouseButton(0))
        {
            if (Input.mousePosition.x < Screen.width / 2f)
            {
                Debug.Log("Add Force!");
                myRigidbody.AddForce(-turnForce, 0, 0);
            }
            else
            {
                myRigidbody.AddForce(turnForce, 0, 0);
            }
        }
    }
}