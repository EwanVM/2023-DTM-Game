using UnityEngine;

public class InventorySlot : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Item item;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        ClearSlot();
    }

    public void AddItem(Item newItem)
    {
        item = newItem;
        spriteRenderer.sprite = newItem.icon;
        spriteRenderer.enabled = true;
    }

    public void ClearSlot()
    {
        item = null;
        spriteRenderer.sprite = null;
        spriteRenderer.enabled = false;
    }

    public void UseItem()
    {
        if (item != null)
        {
            // Use the item (implement your logic here)
            ClearSlot();
        }
    }
}