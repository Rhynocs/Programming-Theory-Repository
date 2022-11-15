using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Connon : MonoBehaviour
{
    [SerializeField] private GameObject pivot;
    [SerializeField] private GameObject connonball;
    [SerializeField] private Transform spawnPosition;
    [SerializeField] private int sensitivity;

    private float xRotation, yRotation;
    private readonly int horizontalLimit = 45, verticalLimit = 25;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        if (GameManager.isGameOver)
            return;

        float x = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float y = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        RotateWithinLimits(x, y);

        if (!IsInvoking() && Input.GetMouseButtonDown(0))
        {
            Instantiate(connonball, spawnPosition);
            Invoke(nameof(BallDelay), 1);
        }
    }

    private void RotateWithinLimits(float horizontal, float vertical)
    {
        xRotation -= vertical;
        yRotation += horizontal;

        xRotation = Mathf.Clamp(xRotation, -verticalLimit, verticalLimit);
        yRotation = Mathf.Clamp(yRotation, -horizontalLimit, horizontalLimit);

        pivot.transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0);
    }

    public void CancelAttackDelay() 
    {
        CancelInvoke();
    }

    private void BallDelay() { }
}
