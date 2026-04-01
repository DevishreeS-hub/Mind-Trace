using UnityEngine;
using TMPro;

public class AutoSelectInput : MonoBehaviour
{
    public TMP_InputField inputField;

    void Start()
    {
        inputField.Select();
        inputField.ActivateInputField();
    }
}
