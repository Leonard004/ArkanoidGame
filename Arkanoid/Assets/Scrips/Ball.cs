using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Vector2 initVelocity;

    private Rigidbody2D ballRD;
    private bool isBallMov;

    // Start is called before the first frame update
    void Start()
    {
        ballRD = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isBallMov)
        {
            Launch();
        }
    }

    private void Launch()
    {
        transform.parent = null;
        ballRD.velocity = initVelocity;
        isBallMov = true;
    }
}
