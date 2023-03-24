using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    [Header("Inscribed")]
    public GameObject robotPrefab;
    public GameObject startButton;

    public void StartPressed() {
        startButton.SetActive(false);
    }    

}
