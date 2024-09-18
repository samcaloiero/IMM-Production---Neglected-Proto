using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class RandomName : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    // Start is called before the first frame update
    void Start()
    {
        RandomNameGen();
    }

    public string[] names =
    {
        "Elias Thorburn",
        "Mira Solace",
        "Lachlan Verity",
        "Adira Voss",
        "Kellan Thorne",
        "Seren Aldridge",
        "Ronan Draven",
        "Elowen Crest",
        "Dorian Falkner",
        "Astra Wynne",
        "Calix Breyer",
        "Sylvia Maren",
        "Orin Ashford",
        "Talia Renwick",
        "Jareth Quinn",
        "Nina Selwyn",
        "Galen Frost",
        "Leona Whitlock",
        "Caspian Vale",
        "Rowan Fenn"
    };

    void RandomNameGen()
    {
        string randomSelectPrompt = names[Random.Range(0, names.Length)];

        nameText.text = randomSelectPrompt;
    }
}
