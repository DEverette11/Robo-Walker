using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Robot : MonoBehaviour
{
    [Header("Inscribed")]
    public GameObject robotPrefab;
    public float speed = 4f;

    public bool buttonActivated = false;

    public void ButtonPressed() {
        buttonActivated = true;
    }

    void Update() {
        if (buttonActivated) {
            Vector3 pos = robotPrefab.transform.position;
            pos.x += speed * Time.deltaTime;
            robotPrefab.transform.position = pos;   
        }
        if (robotPrefab.transform.position.y <= -5) {
            if (SceneManager.GetActiveScene().name == "Level 1") {
                SceneManager.LoadScene("Level 1 Game Over Scene");
            }
            if (SceneManager.GetActiveScene().name == "Level 2") {
                SceneManager.LoadScene("Level 2 Game Over Scene");
            }
        }
    }
}
