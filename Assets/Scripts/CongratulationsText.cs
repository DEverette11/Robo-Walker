using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CongratulationsText : MonoBehaviour
{
    public TextMeshProUGUI congratsText;
    void Start()
    {
        congratsText.text = "Congratulations! You have completed the game! You now have " + PlayerPrefs.GetInt("playerCompletions") + " completions and " + PlayerPrefs.GetInt("playerCoinScore") + " coins! You can press the escape key to quit the game, or press 'Return to Title Screen' to go back to the title screen.";
    }

}
