using UnityEngine;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{
    private readonly float forwardForce = 800.0f;
    private readonly float movableRange = 18f;
    private Animator myAnimator;

    private Rigidbody myRigidbody;
    private readonly float turnForce = 5000.0f;
    private GameObject myGameController;

    private void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        this.myGameController = GameObject.Find("MyGameController");
        myRigidbody.AddForce(transform.forward * forwardForce * 10000);
    }

    private void Update()
    {
        myRigidbody.AddForce(transform.forward * forwardForce);
        if (myRigidbody.velocity.magnitude < 100 && myRigidbody.velocity.magnitude > 5)
        {
            myRigidbody.AddForce(transform.forward * forwardForce * 100);
        }

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

        if (this.transform.position.z > 7950)
        {
            this.myGameController.GetComponent<MyGameController>().GameClear();
        }
    }
}