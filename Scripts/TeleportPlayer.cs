using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class TeleportPlayer : UdonSharpBehaviour
{
    [SerializeField] Transform targetPosition;

    public void OnPlayerTriggerEnter()
    {
        Networking.LocalPlayer.TeleportTo(targetPosition.position, targetPosition.rotation);
    }
}