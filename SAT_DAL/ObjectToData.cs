using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAT_DTO.BusinessObject;

namespace SAT_DAL
{
    static class ObjectToData
    {
        internal static Inventory InventoryOTB(this InventoryBO inventoryBO)
        {
            Inventory inventory = new Inventory()
            {
                InventiryName = inventoryBO.InventoryName,
                InventroyDescription = inventoryBO.Description,
                Price = inventoryBO.Price

            };
            return inventory;
        }
    }
}
