using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class SaveData : MonoBehaviour
{
    private int levelsUnlocked;
    private Color green;
    private Color red;
    [SerializeField] private Button[] buttons;

    private void Start()
    {
        levelsUnlocked = PlayerPrefs.GetInt("unlocked", 1);
        green = new Color(.05166429f,.8113208f,0.5302542f,1);
        red = new Color(0.8679245f, 0.3070488f, 0.3070488f, 1);

        for(int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = false;
            buttons[i].GetComponent<Image>().color = Color.red;
        }

        for(int i = 0; i < levelsUnlocked; i++)
        {
            buttons[i].interactable = true;
            buttons[i].GetComponent<Image>().color = green;
        }
    }

    public int GetLevelsUnlocked()
    {
        return levelsUnlocked;
    }
}

