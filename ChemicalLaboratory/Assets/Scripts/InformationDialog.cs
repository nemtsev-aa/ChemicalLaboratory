using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InformationDialog : MonoBehaviour
{
    [SerializeField] private Image _formulaView;
    [SerializeField] private TextMeshProUGUI _helloText;
    public void ShowFormla(ChemicalElementDescription description)
    {
        _formulaView.sprite = description.Icon;
        _helloText.text = "";
    }

    public void CreateLabel()
    {
        _formulaView.gameObject.SetActive(false);
    }
}
