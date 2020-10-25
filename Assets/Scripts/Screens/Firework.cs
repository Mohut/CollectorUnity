using System;
using UnityEngine;
using Random = UnityEngine.Random;


public class Firework : MonoBehaviour
{
    [SerializeField] private ParticleSystem red;
    [SerializeField] private ParticleSystem green;
    [SerializeField] private ParticleSystem blue;

    private Vector3 position1;
    private Vector3 position2;
    private Vector3 position3;
    private Vector3 position4;

    private void Start()
    {
        position1 = new Vector3(400, 150, 500);
        position2 = new Vector3(-400, 150, 500);
        position3 = new Vector3(310, -110, 500);
        position4 = new Vector3(-310, -110, 500);
        
        InvokeRepeating("FireworkBlast", 1, 1);
    }

    public void FireworkBlast()
    {
        float i = Random.Range(1, 4);
        float a = Random.Range(1, 3);
        ParticleSystem particle;

        if (a < 1f)
        {
            particle = red;
        }else if (a < 2f)
        {
            particle = blue;
        }else
        {
            particle = green;
        }

        if (i < 1f)
        {
            Instantiate(particle, position1, Quaternion.identity);
        }else if (i < 2f)
        {
            Instantiate(particle, position2, Quaternion.identity);
        }else if (i < 3f)
        {
            Instantiate(particle, position3, Quaternion.identity);
        }else
        {
            Instantiate(particle, position4, Quaternion.identity);
        }
    }
}
