using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class SaveData : MonoBehaviour
{
    private int levelsUnlocked;
    [SerializeField] private Button[] buttons;

    private void Start()
    {
        levelsUnlocked = PlayerPrefs.GetInt("unlocked", 1);

        for(int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = false;
            buttons[i].GetComponent<Image>().color = Color.red;
        }

        for(int i = 0; i < levelsUnlocked; i++)
        {
            buttons[i].interactable = true;
            buttons[i].GetComponent<Image>().color = Color.green;
        }
    }

    public int GetLevelsUnlocked()
    {
        return levelsUnlocked;
    }
}

