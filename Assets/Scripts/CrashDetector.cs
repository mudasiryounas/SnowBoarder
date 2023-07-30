using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            Invoke("ReloadScene", 0.5f);
            Debug.Log("You lose!");
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene("Level1");
    }

}
