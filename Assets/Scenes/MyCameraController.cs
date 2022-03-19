using UnityEngine;
using System.Collections;

public class MyCameraController : MonoBehaviour
{
    private GameObject ball;
    private float difference;

    void Start()
    {
        ball = GameObject.Find("Ball");
        difference = ball.transform.position.z - transform.position.z;
    }

    void Update()
    {
        transform.position =
            new Vector3(0, this.transform.position.y, this.ball.transform.position.z - difference);
    }
}