
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;


public class SimpleResetObject : UdonSharpBehaviour
{
    [SerializeField] private GameObject target;
    private Vector3 initialPosition;
    private Quaternion initialRotation;

    void Start()
    {
        initialPosition = target.transform.position;
        initialRotation = target.transform.rotation;
    }

    public void Reset()
    {
        Networking.SetOwner(Networking.LocalPlayer, target);
        target.transform.position = initialPosition;
        target.transform.rotation = initialRotation;
    }    
    
    public override void Interact()
    {
        Reset();
    }
}
