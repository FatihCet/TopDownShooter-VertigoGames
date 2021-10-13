using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace TopDownShooter.Inventory
{

    public abstract class PlayerInventoryItemDataBase : ScriptableObject
    {
        public abstract void CreateIntoInventory(PlayerInventoryController targetPlayerInventory);

    }

 



}

