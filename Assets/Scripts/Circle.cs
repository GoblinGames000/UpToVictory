using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    public float Speed; 

    // Update is called once per frame
    void Update()
    {
        if (CanvasManager.Instance.GamaState == Sate.Play)
        {
            transform.RotateAround(Vector3.zero, new Vector3(0, 0, -1),
                Speed * GameMAnager.Instance.GetSpeed() * Time.deltaTime);
        }
    }
}
