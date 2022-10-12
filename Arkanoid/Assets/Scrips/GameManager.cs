using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //
    private int blocksLeft;
    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    //Inicialiso un contador para los blocks y le diga cuando cambiar la escena
    void Start()
    {
        blocksLeft = GameObject.FindGameObjectsWithTag("Block").Length;
    }

    public void BlockDestroy()
    {
        blocksLeft--;
        if(blocksLeft <= 0)
        {
            LoadNexLevel();
        }
    }
    
    private void LoadNexLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
