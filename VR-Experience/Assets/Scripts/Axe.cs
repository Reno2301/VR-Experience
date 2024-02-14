using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : MonoBehaviour
{
    public GameObject player;
    public Rigidbody rb;
    public float force;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public void Throw()
    {
        rb.useGravity = true;
        rb.AddForce(player.transform.forward * force);
    }
}
