using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checkpoint : MonoBehaviour
{

    public void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("Level2");

    }
}
