using UnityEngine;

public class ChemicalElement : MonoBehaviour
{
    [field: SerializeField] public ChemicalElementDescription Description { get; private set; }

    private void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody.TryGetComponent(out MixingVat vat))
        {
            vat.ShowDesciption(Description);
            Destroy(gameObject);
        }
    }
}
