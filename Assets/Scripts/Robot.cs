using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot : MonoBehaviour
{
        [Header("Inscribed")]
    public GameObject robotPrefab;
    public float speed = 4f;

    public bool buttonActivated = false;
    public Collider2D robotCollider;
    public Collider2D doorCollider;
    public Collider2D lavaCollider;
    public Collider2D springCollider;


    //void Start() {
        //springCollider = GameObject.FindGameObjectWithTag("Spring").GetComponent<Collider2D>();
        //lavaCollider = GameObject.FindGameObjectWithTag("Lava").GetComponent<Collider2D>();
        //doorCollider = GameObject.FindGameObjectWithTag("Door").GetComponent<Collider2D>();
        //robotCollider = GameObject.FindGameObjectWithTag("Robot").GetComponent<Collider2D>();
    //}
    public void ButtonPressed() {
        buttonActivated = true;
    }

    void Update() {
        if (buttonActivated) {
            Vector3 pos = robotPrefab.transform.position;
            pos.x += speed * Time.deltaTime;
            robotPrefab.transform.position = pos;   
        }
    }

    public void OnCollisionEnter2D(Collision2D collision) {
        Debug.Log("Collision");
        if (collision.gameObject.tag == "Lava") {
            Debug.Log("Touched Lava");
        }
        if (collision.gameObject.tag == "Door") {
            Debug.Log("Touched Door");
        }
        if (collision.gameObject.tag == "Spring") {
            Debug.Log("Touched Spring");
        }
    }
}
