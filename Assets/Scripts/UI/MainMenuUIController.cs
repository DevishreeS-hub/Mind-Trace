using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MainMenuUIController : MonoBehaviour
{
    [SerializeField] private Button startButton;
    [SerializeField] private TMP_InputField inputField;

    [SerializeField] private GamePlayUIController gamePlayUIController;

    private void Start()
    {
        startButton.onClick.AddListener(OnStartButtonClicked);
    }

    private void OnStartButtonClicked()
    {
        if(!string.IsNullOrWhiteSpace(inputField.text))
        {
            gamePlayUIController.SetText(inputField.text);
            gameObject.SetActive(false);
        }
    }
}