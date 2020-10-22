using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timer;
    public TextMeshProUGUI timerText;
    [SerializeField] private ParticleSystem ps;
    private bool exploded;
    private Vector3 position;

    private void Start()
    {
        exploded = false;
        position = new Vector3(-77f, 7.5f, 0f);
        //for the first three seconds
        timer += 3;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 20)
        {
           timerText.text = timer.ToString("0");
           transform.localScale = Vector3.one * (3 - (timer * 0.1f)); 
        }

        if(timer < .5f && !exploded)
        {
            timerText.enabled = false;
            Instantiate(ps, position, Quaternion.Euler(-90, 0, 0));
            exploded = true;
        }
    }
}