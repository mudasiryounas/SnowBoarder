using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] ParticleSystem finishEffect;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            finishEffect.Play();
            Invoke("ReloadScene", 1f);
            Debug.Log("You win!");
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene("Level1");
    }
}
