using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BntHome : MonoBehaviour
{
    public void home()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
