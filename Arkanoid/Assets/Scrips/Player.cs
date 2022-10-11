using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float movSpeed;
    private float bouns = 11f;

    // Update is called once per frame
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
