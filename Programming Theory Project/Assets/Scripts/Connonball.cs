using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Connonball : MonoBehaviour
{
    [SerializeField] private int force;
    
    void Start()
    {
        transform.parent = null;
        GetComponent<Rigidbody>().AddForce(transform.forward * force, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
    {
        // explosion effect
        Destroy(gameObject);
    }
}
