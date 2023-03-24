using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CoinCounter : MonoBehaviour
{
    public TextMeshProUGUI coinText;
    void FixedUpdate() {
        coinText.text = "Coins: " + PlayerPrefs.GetInt("playerCoinScore");
    }
}
