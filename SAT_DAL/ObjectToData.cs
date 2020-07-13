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
        //Chage the business object to sql data object
        //We are doint this to maintain the architecture
        internal static Inventory ToInventoryOTB(this InventoryBO inventoryBO)
        {
            Inventory inventory = new Inventory()
            {
                InventoryId = inventoryBO.Id,
                InventiryName = inventoryBO.InventoryName,
                InventroyDescription = inventoryBO.Description,
                Price = inventoryBO.Price

            };
            return inventory;
        }
    }
}
