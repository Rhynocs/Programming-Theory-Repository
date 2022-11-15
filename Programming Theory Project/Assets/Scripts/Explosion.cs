using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    private void Awake()
    {
        transform.parent = null;
    }

    private void Start()
    {
        Destroy(gameObject, 0.5f);
    }
}
