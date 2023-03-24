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
            if (SceneManager.GetActiveScene().name == "Level 1") {
                SceneManager.LoadScene("Level 1 Game Over Scene");
            }
            if (SceneManager.GetActiveScene().name == "Level 2") {
                SceneManager.LoadScene("Level 2 Game Over Scene");
            }
        }
        if (collision.gameObject.tag == "Door") {
            if (SceneManager.GetActiveScene().name == "Level 1") {
                SceneManager.LoadScene("Level 1 Complete Scene");
            }
            if (SceneManager.GetActiveScene().name == "Level 2") {
                SceneManager.LoadScene("Level 2 Complete Scene");
            }
            PlayerPrefs.SetInt("playerCompletions", PlayerPrefs.GetInt("playerCompletions") + 1);
        }
        if (collision.gameObject.tag == "Spring") {
            robotPrefab.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,8), ForceMode2D.Impulse);
        }
        if (collision.gameObject.tag == "Coin") {
            PlayerPrefs.SetInt("playerCoinScore", PlayerPrefs.GetInt("playerCoinScore") + 1);
            collision.gameObject.SetActive(false);
        }
    }
}
