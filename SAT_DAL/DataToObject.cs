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
        //Chage the sql data object to business object
        //We are doint this to maintain the architecture and get the information on control level
        //we can get information like what element added, what is modified, what go deleted etc 
        //Controller can understand Business object so we are converting the Sql data object to business object
        internal static InventoryBO ToInventoryDTO(this Inventory inventory)
        {
            InventoryBO inventoryBO = new InventoryBO()
            {
                Id = inventory.InventoryId,
                InventoryName = inventory.InventiryName,
                Description = inventory.InventroyDescription,
                Price = inventory.Price
            };
            return inventoryBO;
        }

    }
}
