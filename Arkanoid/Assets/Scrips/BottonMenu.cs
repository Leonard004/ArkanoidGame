using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BottonMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("Nivel_1");
    }
}
