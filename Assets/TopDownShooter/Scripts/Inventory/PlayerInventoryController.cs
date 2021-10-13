using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TopDownShooter.Inventory
{
    public class PlayerInventoryController : MonoBehaviour
    {
        [SerializeField] private PlayerInventoryItemDataBase[] _inventoryItemDataArray;
        public Transform Parent;
        private void Start()
        {
            //For Testing Purposes Only
            InitializeInventory(_inventoryItemDataArray);

        }


        public void InitializeInventory(PlayerInventoryItemDataBase[] inventoryItemDataArray)
        {
            for (int i = 0; i < inventoryItemDataArray.Length; i++)
            {
                inventoryItemDataArray[i].CreateIntoInventory(this);
            }

        }
    }


}

