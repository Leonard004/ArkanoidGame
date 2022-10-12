using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //Comando que que permite manipular los valores desde Unity
    [SerializeField] private Vector2 initVelocity;
    [SerializeField] private float velocityMultiplayer;

    private Rigidbody2D ballRD;
    private bool isBallMov;

    //inicialisar el Rigibode para la ficica.
    void Start()
    {
        ballRD = GetComponent<Rigidbody2D>();
    }

    //Le diho al comando que interactue con la barra espacio o Space, para dispararla bola
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isBallMov)
        {
            Launch();
        }
    }

    //Inicialiso la loguica para la velocidad inicila de la bola 
    private void Launch()
    {
        transform.parent = null;
        ballRD.velocity = initVelocity;
        isBallMov = true;
    }

    //LE digo al programa que si la bola toca el Tag Block, destrulla ese objeto 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Block"))
        { 
            Destroy(collision.gameObject);
            ballRD.velocity *= velocityMultiplayer;
            GameManager.Instance.BlockDestroy();
        }
        velocityFix();
    }

    //Para evitar que la bola se mantenga en un loop infinito, inicialisa un random para que combie de direccion
    private void velocityFix()
    {
        float velocityDelta = 0.2f;
        float minVelocity = 0.1f;

        if(Mathf.Abs(ballRD.velocity.x) < minVelocity)
        {
            velocityDelta = Random.value <0.1f ? velocityDelta : -velocityDelta;
            ballRD.velocity += new Vector2(velocityDelta, 0f);
        }

        if (Mathf.Abs(ballRD.velocity.y) < minVelocity)
        {
            velocityDelta = Random.value < 0.1f ? velocityDelta : -velocityDelta;
            ballRD.velocity += new Vector2(0f, velocityDelta);
        }

    }
}
