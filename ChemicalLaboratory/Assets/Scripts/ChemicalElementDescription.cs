using System;
using UnityEngine;

[Serializable]
public class ChemicalElementDescription
{
    [field: SerializeField] public string Name { get; private set; }
    [field: SerializeField] public Sprite Icon { get; private set; }

}
