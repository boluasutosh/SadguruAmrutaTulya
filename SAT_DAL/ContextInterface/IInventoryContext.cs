using SAT_DTO.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SAT_DAL.ContextInterface
{
    public interface IInventoryContext
    {
        ResponseBO<InventoryBO> AddInventory(InventoryBO inventoryBO);
        ResponseBO<InventoryBO> ModifyInventory(InventoryBO inventoryBO);
        ResponseBO<InventoryBO> DeleteInventory(InventoryBO inventoryBO);
        ResponseBO<InventoryBO> DeleteInventory(int id);
        IEnumerable<InventoryBO> GetAllInventory();
        ResponseBO<InventoryBO> GetInventoryById(int id);

    }
}
