
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class SimpleSwitch : UdonSharpBehaviour
{
    [SerializeField] private GameObject Target;

    public override void Interact()
    {
        Target.SetActive(!Target.activeSelf);
    }
}
