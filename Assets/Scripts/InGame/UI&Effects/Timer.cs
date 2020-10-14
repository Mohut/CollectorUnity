using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timer;
    public Text timerText;
    [SerializeField] private Text text;
    [SerializeField] private ParticleSystem ps;
    private Vector3 position;

    private void Start()
    {
        position = new Vector3(-50, 45, 0);
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        timerText.text = timer.ToString("0");
        text.fontSize = (int) (100f - timer * 2);
        if(timer < 0.5)
        {
            text.enabled = false;
            Instantiate(ps, position, Quaternion.identity);
        }
    }
}