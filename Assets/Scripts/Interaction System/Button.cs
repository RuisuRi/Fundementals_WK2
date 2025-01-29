using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;
    string IInteractable.InteractionPromt => throw new System.NotImplementedException();
    public string InteractPromt { get; }
    public bool Interact(Interactor interactor)
    {
        Debug.Log("Hi");
        return true;
    }


    
}
