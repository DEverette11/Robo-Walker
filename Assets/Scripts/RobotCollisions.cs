using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RobotCollisions : MonoBehaviour
{
    [Header("Inscribed")]
    public float jumpHeight = 10f;
    public GameObject robotPrefab;

    public void OnTriggerEnter2D(Collider2D collision) {
        print("Collision");
        if (collision.gameObject.tag == "Lava") {
            SceneManager.LoadScene("Level 1 Game Over Scene");
        }
        if (collision.gameObject.tag == "Door") {
            SceneManager.LoadScene("Level 1 Complete Scene");
        }
        if (collision.gameObject.tag == "Spring") {
            robotPrefab.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,8), ForceMode2D.Impulse);
        }
    }
}
