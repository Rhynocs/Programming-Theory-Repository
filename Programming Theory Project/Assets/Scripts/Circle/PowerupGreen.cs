using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupGreen : Powerup // Inheritance
{
    // Polymorphism
    protected override void SetLifespan()
    {
        DestroyInSeconds = 3;
    }

    // Polymorphism
    protected override void Destroy(int seconds)
    {
        Destroy(gameObject, seconds);
    }  
}
