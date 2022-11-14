using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Circle : MonoBehaviour
{
    [SerializeField] protected int score;
    

    private int destroyInSeconds = 5;
    protected int DestroyInSeconds // Encapsulation
    {
        set
        {
            if (value < 2)
            {
                Debug.Log("Circles shouldn't be destroyed so quickly!");
            }
            else if (value > 100)
            {
                Debug.Log("We wouldn't want it to stay here forever, would we?");
            }
            else
            {
                destroyInSeconds = value;
            }
        }
    }

    private void Start()
    {
        transform.parent = null;
        
        SetPosition(); // Abstraction

        SetLifespan(); // Abstraction
        Destroy(destroyInSeconds);
    }

    private void Update()
    {

    }

    protected virtual void SetPosition()
    {
        float x = Random.Range(-7, 7);
        float y = Random.Range(3, 5);
        float z = Random.Range(0, 20);

        transform.SetPositionAndRotation(new Vector3(x, y, z), Quaternion.identity);
    }

    private void OnDestroy()
    {
        GameManager.onDestroy.Invoke();
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject, 0.5f);
        transform.GetChild(0).gameObject.SetActive(true);
        GameManager.trigger.Invoke(score);
        // effect
    }

    protected abstract void SetLifespan();
    protected abstract void Destroy(int seconds);
}
