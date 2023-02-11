using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public float baseSize = 1f;

    private void Update()
    {
        float animation = baseSize + Mathf.Sin(Time.time * 8) * baseSize / 7f;
        transform.localScale = Vector3.one * animation;
    }
}
