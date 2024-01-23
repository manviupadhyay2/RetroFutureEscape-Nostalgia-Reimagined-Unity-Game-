using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Level3_NameTag : MonoBehaviour
{
    public string characterName; // Set the default name here.
    private TextMeshPro nameText;

    private void Start()
    {
        nameText = GetComponent<TextMeshPro>();
        if (nameText != null)
        {
            nameText.text = characterName;
        }
    }
}
