using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashAudioClip;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Ground")
        {
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashAudioClip);
            Invoke("ReloadScene", 0.5f);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene("Level1");
    }

}
