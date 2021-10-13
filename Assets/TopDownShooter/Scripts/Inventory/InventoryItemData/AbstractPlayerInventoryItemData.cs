using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TopDownShooter.Inventory
{
    public abstract class AbstractPlayerInventoryItemData<T> : ScriptableObject where T:
        AbstractPlayerInventoryItemMono
    {

        public enum InventoryItemDataType { Cannon,Body}


        [SerializeField] protected string _itemId;
        [SerializeField] protected InventoryItemDataType _inventoryItemDataType;
        [SerializeField] protected T _prefab;
        public virtual void CreateIntoInventory(PlayerInventoryController targetPlayerInventory)
        {


        }



        protected T InstantiateAndInitializePrefab(Transform parent)
        {

           return  Instantiate(_prefab, parent);
        }

        
    }

}

