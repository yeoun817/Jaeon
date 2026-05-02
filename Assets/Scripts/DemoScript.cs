using UnityEngine;

public class DemoScript : MonoBehaviour
{
    public InventoryManager inventoryManager;
    public Item[] itmesToPickup;

    public void PickupItem(int id)
    {
        bool result = inventoryManager.AddItem(itmesToPickup[id]);

        if (result)
            Debug.Log("item added");
        else
            Debug.Log("item didn't added");
    }
}
