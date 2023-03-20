using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2Restart : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("Level 2");
    }
}
