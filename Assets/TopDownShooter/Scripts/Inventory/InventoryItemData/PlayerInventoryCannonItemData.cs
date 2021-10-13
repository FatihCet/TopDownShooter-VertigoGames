using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TopDownShooter.Inventory
{
    
    [CreateAssetMenu(menuName = "TopDownShooter/Inventory/Player İnventory Canon Data")]
    public class PlayerInventoryCannonItemData : AbstractPlayerInventoryItemData<PlayerInventoryItemCannonMono>
    {
        public override void CreateIntoInventory(PlayerInventoryController targetPlayerInventory)
        {
            var instantiated = InstantiateAndInitializePrefab(targetPlayerInventory.Parent);

            Debug.Log("This class is player ınventory canon ıtem data");
        }
    }


}




