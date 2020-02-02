using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientActivity : MonoBehaviour
{
    private float zAxisAngle;
    private float rotationSpeed = 1;
    private bool isRotating = true;

    private void Awake()
    {
        StartCoroutine(SetNewEulerAngle());
    }

    private IEnumerator SetNewEulerAngle()
    {
        while(isRotating)
        {
            zAxisAngle = -15;
            yield return new WaitForSeconds(0.5f);
            zAxisAngle = 15;
            yield return new WaitForSeconds(0.5f);
        }
    }

    private void Update()
    {
        transform.Rotate(0, 0, zAxisAngle * Time.deltaTime * rotationSpeed) ;
    }
}
