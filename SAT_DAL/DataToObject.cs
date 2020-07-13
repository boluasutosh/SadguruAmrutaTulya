using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAT_DTO.BusinessObject;

namespace SAT_DAL
{
    static class DataToObject
    {
        internal static InventoryBO InventoryDTO(this Inventory inventory)
        {
            InventoryBO inventoryBO = new InventoryBO()
            {
                InventoryName = inventory.InventiryName,
                Description = inventory.InventroyDescription,
                Price = inventory.Price
            };
            return inventoryBO;
        }

    }
}
