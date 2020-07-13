using SAT_DTO.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SAT_DAL.ContextInterface
{
    internal interface IInventory
    {
        ResponseBO<InventoryBO> AddInventory(InventoryBO inventoryBO);
        InventoryBO ModifyInventory(InventoryBO inventoryBO);
        bool DeleteInventory(InventoryBO inventoryBO);
        List<InventoryBO> GetAllInventory();
        InventoryBO GetInventoryById(int id);

    }
}
