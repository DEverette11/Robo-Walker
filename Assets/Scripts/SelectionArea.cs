using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionArea : MonoBehaviour
{
    public int count = 0;
    public GameObject ground;
    public GameObject groundWithSpring;

    void OnMouseDown() {
        count++;
        if (count >= 3) {
            count = 0;
        }
        if (count == 0) {
            groundWithSpring.SetActive(false);
        }
        if (count == 1) {
            ground.SetActive(true);
        }
        if(count == 2) {
            ground.SetActive(false);
            groundWithSpring.SetActive(true);
        }
    }
}
