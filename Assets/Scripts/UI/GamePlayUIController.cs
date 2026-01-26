using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GamePlayUIController : MonoBehaviour
{
    [SerializeField] private TMP_Text nameText;

    public void SetText(string name)
    {
        nameText.text = name;
    }
}
