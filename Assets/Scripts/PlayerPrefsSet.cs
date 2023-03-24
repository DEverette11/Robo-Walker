using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsSet : MonoBehaviour
{
    
    public void playerPrefsStart() {
        PlayerPrefs.SetInt("playerCompletions", 0);
        PlayerPrefs.SetInt("playerCoinScore", 0);
    }
}
