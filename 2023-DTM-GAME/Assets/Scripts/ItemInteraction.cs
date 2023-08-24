using UnityEngine;

public class ItemInteraction : MonoBehaviour
{
    public KeyCode interactKey = KeyCode.F;
    public Item item; // The Item to be added to the inventory

    private void Update()
    {
        if (Input.GetKeyDown(interactKey))
        {
            PickupItem();
        }
    }

    private void PickupItem()
    {
        InventoryManager inventoryManager = FindObjectOfType<InventoryManager>();

        if (inventoryManager != null && item != null)
        {
            bool successfullyAdded = inventoryManager.AddItem(item);

            if (successfullyAdded)
            {
                // Successfully added to inventory, so remove the item from the scene
                Destroy(gameObject);
            }
        }
    }
}
