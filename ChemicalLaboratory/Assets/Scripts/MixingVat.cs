using UnityEngine;

public class MixingVat : MonoBehaviour
{
    [SerializeField] private InformationDialog _dialog;

    public void ShowDesciption(ChemicalElementDescription description)
    {
        _dialog.ShowFormla(description);
    }
}
