using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Comando que que permite manipular los valores desde Unity y le otorgo a bouns un valor
    [SerializeField] private float movSpeed;
    private float bouns = 11f;

    //Le digo al programa que el jugador solo puede moverse en horizontal y le inpido llegar a cierrto punto en x
    void Update()
    {
        Move();
    }

    private void Move()
    {
        float movInpunt = Input.GetAxisRaw("Horizontal");
        Vector2 playerPosition = transform.position;
        playerPosition.x = Mathf.Clamp(playerPosition.x + movInpunt * movSpeed * Time.deltaTime, -bouns, bouns);
        transform.position = playerPosition;
    }
}
