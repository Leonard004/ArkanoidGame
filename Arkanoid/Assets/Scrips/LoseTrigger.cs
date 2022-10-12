using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseTrigger : MonoBehaviour
{
    //Un trigger para cambiar de ecsena
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.Instance.ReloadScene();
    }
}
