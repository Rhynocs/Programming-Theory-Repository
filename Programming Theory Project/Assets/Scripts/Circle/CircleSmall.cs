using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleSmall : Circle // Inheritance
{
    // Polymorphism
    protected override void SetPosition()
    {
        float x = Random.Range(-6, 7);
        float y = Random.Range(3, 5);
        float z = Random.Range(10, 15);

        transform.SetPositionAndRotation(new Vector3(x, y, z), Quaternion.identity);
    }
    
    // Polymorphism
    protected override void SetLifespan()
    {
        DestroyInSeconds = 6;
    }

    // Polymorphism
    protected override void Destroy(int seconds)
    {
        Destroy(gameObject, seconds);
    } 
}
