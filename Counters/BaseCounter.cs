using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Unity.Netcode;

public class BaseCounter : NetworkBehaviour, IKitchenObjectParent
{

    public static event EventHandler OnAnyObjectPlacedHere;

    public static void ResetStaticData()
    {
        OnAnyObjectPlacedHere = null;
    }

    [SerializeField] private Transform counterTopPoint;

    private KitchenObject kitchenObject;

    public virtual void Interact(Player player)
    {
        Debug.LogError("BasCounter.Interact();");
    }
    public virtual void InteractAlternate(Player player)
    {
        Debug.LogError("BasCounter.InteractAlternate();");
    }
    public Transform GetKittchenObjectFollwTransform()
    {
        return counterTopPoint;
    }
    public void SetKitchenObject(KitchenObject kitchenObject)
    {
        this.kitchenObject = kitchenObject;

        if (kitchenObject != null)
        {
            OnAnyObjectPlacedHere?.Invoke(this, EventArgs.Empty);
        }
    }

    public KitchenObject GetKitchenObject()
    {
        return kitchenObject;
    }
    public void ClearKitchenObject()
    {
        kitchenObject = null;
    }

    public bool HasKitchenObject()
    {
        return kitchenObject != null;
    }

    public NetworkObject GetNetworkObject()
    {
        return NetworkObject;
    }
}
