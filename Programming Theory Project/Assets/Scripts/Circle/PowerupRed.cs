using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupRed : Powerup // Inheritance 
{
    // Polymorphism
    protected override void SetPosition()
    {
        float x = Random.Range(-7, 7);
        float y = Random.Range(4, 6);
        float z = Random.Range(0, 10);

        transform.SetPositionAndRotation(new Vector3(x, y, z), Quaternion.identity);
    }

    // Polymorphism
    protected override void SetLifespan()
    {
        DestroyInSeconds = 5;
    }

    // Polymorphism
    protected override void Destroy(int seconds)
    {
        Destroy(gameObject, seconds);
    }
}
