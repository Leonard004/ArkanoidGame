using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BottonPausa : MonoBehaviour
{
    public void Pause()
    {
        SceneManager.LoadScene("Pausa");
    }
}
