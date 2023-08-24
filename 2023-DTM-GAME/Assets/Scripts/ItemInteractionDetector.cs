using UnityEngine;

public class ItemInteractionDetector : MonoBehaviour
{
    private Camera camera;

    private void Start()
    {
        camera = Camera.main;
    }

    private void Update()
    {
        RaycastHit hit;
        Ray ray = camera.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));

        if (Physics.Raycast(ray, out hit))
        {
            ItemInteraction itemInteraction = hit.collider.GetComponent<ItemInteraction>();

            if (itemInteraction != null)
            {
                // Display UI prompt to inform the player to press 'F' to pick up the item
                // Implement UI prompt display or feedback as needed
            }
        }
        else
        {
            // Hide the UI prompt if no item is being looked at
            // Implement UI prompt hide as needed
        }
    }
}
