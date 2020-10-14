using System;
using System.Collections;
using Unity.Collections;
using UnityEditor.Rendering;
using UnityEngine;
using Random = UnityEngine.Random;

public class CameraShake : MonoBehaviour
{
    public IEnumerator Shake(float duration, float magnitude)
    {
        Vector3 originalPosition = transform.localPosition;

        float elapse = 0.0f;

        while (elapse < duration)
        {
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;

            transform.localPosition = new Vector3(x, y, originalPosition.z);

            elapse += Time.deltaTime;
            yield return null;
        }
        
        transform.localPosition = originalPosition;
    }

    public void Shaker()
    {
        StartCoroutine(Shake(.1f, .01f));
    }
    
}
