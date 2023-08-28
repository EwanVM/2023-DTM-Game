using UnityEngine;

public class WinManager : MonoBehaviour
{
    public GameObject winScreenUI;
    public GameObject[] entitiesToCheck;

    private bool hasWon = false;

    void Start()
    {
        winScreenUI.SetActive(false);
    }

    void Update()
    {
        // Check if all entities are destroyed
        bool allEntitiesDestroyed = true;
        foreach (GameObject entity in entitiesToCheck)
        {
            if (entity != null)
            {
                allEntitiesDestroyed = false;
                break;
            }
        }

        // Check win condition if all entities are destroyed
        if (allEntitiesDestroyed && !hasWon)
        {
            hasWon = true;
            winScreenUI.SetActive(true);
        }
    }
}
