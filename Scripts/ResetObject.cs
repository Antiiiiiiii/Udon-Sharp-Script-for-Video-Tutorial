
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;


public class ResetObject : UdonSharpBehaviour
{
    [SerializeField] private GameObject[] controlledObjects;
    private Vector3[] initialPositions;
    private Quaternion[] initialRotations;

    void Start()
    {
        initialPositions = new Vector3[controlledObjects.Length];
        initialRotations = new Quaternion[controlledObjects.Length];
        for (int i = 0; i < controlledObjects.Length; i++)
        {
            initialPositions[i] = controlledObjects[i].transform.position;
            initialRotations[i] = controlledObjects[i].transform.rotation;
        }
    }

    public void Reset()
    {
        for (int i = 0; i < controlledObjects.Length; i++)
        {
            Networking.SetOwner(Networking.LocalPlayer, controlledObjects[i]);
            controlledObjects[i].transform.position = initialPositions[i];
            controlledObjects[i].transform.rotation = initialRotations[i];
        }
    }    
    
    public override void Interact()
    {
        Reset();
    }
}
