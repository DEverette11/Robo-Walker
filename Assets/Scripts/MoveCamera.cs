using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        }       
    }
}
