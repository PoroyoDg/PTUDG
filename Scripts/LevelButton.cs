using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelButton : MonoBehaviour
{
    public Button[] buttons;
    public GameObject levelButtons;


    private void Awake()
    {
        ButtonToArray();
        int unlockedLevel = PlayerPrefs.GetInt("UnlockedLevel", 1);
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = false;
        }
        for (int i = 0; i < unlockedLevel; i++)
        {
            buttons[i].interactable = true;
        }
    }

    public void openLevel(int levelId)
    {
        //string levelName = "Level" + levelId;
        string levelName = "SampleScene";
        SceneManager.LoadScene(levelName);
    }

    void ButtonToArray()
    {
        int ChildCount = levelButtons.transform.childCount;
        buttons =  new Button[ChildCount];
        for (int i = 0; i < ChildCount; i++)
        {
            buttons[i] = levelButtons.transform.GetChild(i).gameObject.GetComponent<Button>();
        }
    }
}
