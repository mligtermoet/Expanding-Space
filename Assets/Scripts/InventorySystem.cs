using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    public GameObject Inventory;

    // Start is called before the first frame update
    public void OpenInventory()
    {
        if (Inventory != null)
        {
            bool isActive = Inventory.activeSelf;
            Inventory.SetActive(!isActive);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
