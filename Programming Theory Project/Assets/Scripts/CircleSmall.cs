using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleSmall : Circle // Inheritance
{
    // Polymorphism
    protected override void SetLifespan()
    {
        DestroyInSeconds = 8;
    }

    // Polymorphism
    protected override void Destroy(int seconds)
    {
        Destroy(gameObject, seconds);
    }

    // Polymorphism
    protected override void SetPosition()
    {
        float x = Random.Range(-7, 7);
        float y = Random.Range(3, 5);
        float z = Random.Range(10, 20);

        transform.SetPositionAndRotation(new Vector3(x, y, z), Quaternion.identity);
    }
}
