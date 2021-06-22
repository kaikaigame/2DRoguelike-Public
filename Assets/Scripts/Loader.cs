using UnityEngine;
using System.Collections;
using Completed;

public class Loader : MonoBehaviour
{
    //GameManager prefab to instantiate.
    public GameObject gameManager;

    //SoundManager prefab to instantiate.
    public GameObject soundManager;

    void Awake()
    {
        //Check if a GameManager has already been assigned 
        //to static variable GameManager.
        //instance or if it's still null
        if (GameManager.instance == null)
            //Instantiate gameManager prefab
            Instantiate(gameManager);

        //Check if a SoundManager has already been assigned 
        //to static variable SoundManager.
        //instance or if it's still null
        if (SoundManager.instance == null)
            //Instantiate SoundManager prefab
            Instantiate(soundManager);
    }
}