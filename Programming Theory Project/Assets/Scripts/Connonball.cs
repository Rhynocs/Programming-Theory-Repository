using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Connonball : MonoBehaviour
{
    [SerializeField] private int force;
    [SerializeField] private GameObject explosionEffect;

    void Start()
    {
        transform.parent = null;
        GetComponent<Rigidbody>().AddForce(transform.forward * force, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(explosionEffect, transform);
        Destroy(gameObject);
    }
}
