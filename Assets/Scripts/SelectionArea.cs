using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionArea : MonoBehaviour
{
    public int count = 0;
    public GameObject ground;
    public GameObject groundWithSpring;
    public Behaviour halo;

    void OnMouseDown() {
        count++;
        if (count >= 3) {
            count = 0;
        }
        if (count == 0) {
            halo.enabled = true;
            groundWithSpring.SetActive(false);
        }
        if (count == 1) {
            halo.enabled = false;
            ground.SetActive(true);
        }
        if(count == 2) {
            ground.SetActive(false);
            groundWithSpring.SetActive(true);
        }
    }
}
