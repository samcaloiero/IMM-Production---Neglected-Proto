using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RandomPrompt : MonoBehaviour
{

    public TextMeshProUGUI promptText;
    void Start()
    {
        PopulateTXTRandomString();
    }
    

    public string[] prompts =
    {
        "photograph a Neglected Item from your bag",

        "photograph a Neglected utensil in your kitchen",

        "photograph a book you've Neglected to read",

        "photograph a shirt you've Neglected to wear",

        "photograph a game you've Neglected to play",

        "photograph a Neglected item you stole",

        "photograph a gift you've Neglected to touch",

        "photograph a piece of technology you've Neglected",

        "photograph a Neglected item in your car",

        "photograph a Neglected piece of hardware",
        
        "photograph a pair of shoes you've Neglected to wear",
        
        "photograph a plant you've Neglected to water",
        
        "photograph a piece of jewelry you've Neglected to wear",
        
        "photograph a hobby kit you've Neglected to finish",
        

    };

    void PopulateTXTRandomString()
    {
        string randomSelectPrompt = prompts[Random.Range(0, prompts.Length)];

        promptText.text = randomSelectPrompt;

    }
}
