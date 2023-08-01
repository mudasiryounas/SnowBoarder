using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] ParticleSystem crashEffect;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            crashEffect.Play();
            Invoke("ReloadScene", 0.5f);
            Debug.Log("You lose!");
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene("Level1");
    }

}
