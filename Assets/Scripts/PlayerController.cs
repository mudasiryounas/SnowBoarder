using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb2d;
    [SerializeField] float torqueAmount = 10f;
    [SerializeField] float normalSpeed = 20f;
    [SerializeField] float boostSpeed = 30f;
    SurfaceEffector2D surface;
    [SerializeField] ParticleSystem snowParticles;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        surface = FindObjectOfType<SurfaceEffector2D>();
    }

    void Update()
    {
        RoratePlayer();
        RespondToBoost();
    }

    void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Ground")
        {
            snowParticles.Play();
        }
    }

    void OnCollisionExit2D(Collision2D other) {
        if (other.gameObject.tag == "Ground")
        {
           snowParticles.Stop();
        }
    }

    void RoratePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(torqueAmount);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddTorque(-torqueAmount);
        }
    }

    void RespondToBoost()
    {
        // boost player speed when player is moving up on the incline
        if (Input.GetKey(KeyCode.UpArrow))
        {
            surface.speed = boostSpeed;
        }
        else
        {
            surface.speed = normalSpeed;
        }


    }

}
