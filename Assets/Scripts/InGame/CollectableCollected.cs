using UnityEngine;

public class CollectableCollected : MonoBehaviour
{
    public bool isBlue;
    private bool played;
    public ParticleSystem particleSystemB;
    public ParticleSystem particleSystemR;
    private Camera camera;
    private CameraShake cameraShake;
    private bool canShake;

    private void Start()
    {
        camera = Camera.main;
        cameraShake = camera.GetComponent<CameraShake>();
    }

    private void OnTriggerStay(Collider other) {
        if (FindObjectOfType<PlayerActions>().isBlue && isBlue || !FindObjectOfType<PlayerActions>().isBlue && !isBlue)
        {
            if (isBlue)
            {
                Instantiate(particleSystemB, transform.position, Quaternion.identity);
            }
            else
            {
                Instantiate(particleSystemR, transform.position, Quaternion.identity);
            }

            cameraShake.Shaker();
            
            Destroy(gameObject);
              
            //decreasing object bar
            FindObjectOfType<ObjectBar>().decrementProgress();
            
        }
    }


}