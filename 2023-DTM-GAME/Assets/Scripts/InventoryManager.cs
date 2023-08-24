using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public GameObject inventoryUI;
    public GameObject slotPrefab; // Drag your inventory slot prefab here
    public Transform inventorySlotsParent;
    public InventorySlot[] inventorySlots;

    private void Start()
    {
        inventorySlots = new InventorySlot[inventorySlotsParent.childCount];

        for (int i = 0; i < inventorySlotsParent.childCount; i++)
        {
            inventorySlots[i] = inventorySlotsParent.GetChild(i).GetComponent<InventorySlot>();
        }

        inventoryUI.SetActive(false); // Hide the inventory initially
    }

    public void ToggleInventory()
    {
        inventoryUI.SetActive(!inventoryUI.activeSelf);
    }

    public bool AddItem(Item newItem)
    {
        foreach (InventorySlot slot in inventorySlots)
        {
            if (slot.item == null)
            {
                slot.AddItem(newItem);
                return true;
            }
        }
        return false; // Inventory is full
    }
}
