using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    public float speed = 50;
    private string sumbu;
    private bool putar;

    void Update()
    {
        if (putar)
        {
            if (sumbu.ToUpper().Equals("Z"))
            {
                transform.Rotate(Vector3.forward * speed);
            }
        }
    }
    public void RotateCube(string sumbu)
    {
        this.sumbu = sumbu;
        putar = true;
    }
    public void StopRotation()
    {
        putar = false;
    }
}
