using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveCamera : MonoBehaviour
{
    // Update is called once per frame
    [Header("Inscribed")]
    public float speed = 5.0f;
    public bool buttonPressed = false;

    public void buttonActivated() {
        buttonPressed = true;
    }

    void Update() {
        if(!buttonPressed) {
            if (Input.GetKey(KeyCode.RightArrow)) {
                transform.position += new Vector3(speed * Time.deltaTime,0,0);
            }
            if (Input.GetKey(KeyCode.LeftArrow)) {
                transform.position += new Vector3(-speed * Time.deltaTime,0,0);
            }
            if (transform.position.x < 0) {
                Vector3 newPosition = new Vector3(0, transform.position.y, transform.position.z);
                transform.position = newPosition;
            }
            if (SceneManager.GetActiveScene().name == "Level 1") {
                if (transform.position.x > 14) {
                    Vector3 newPosition = new Vector3(14, transform.position.y, transform.position.z);
                    transform.position = newPosition;
                }
            }
            if (SceneManager.GetActiveScene().name == "Level 2") {
                if (transform.position.x > 13) {
                    Vector3 newPosition = new Vector3(13, transform.position.y, transform.position.z);
                    transform.position = newPosition;
                }           
            }

        }       
    }
}
