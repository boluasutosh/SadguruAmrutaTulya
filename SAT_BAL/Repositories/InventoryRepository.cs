using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SAT_BAL.IRepositories;
using SAT_DAL.ContextClass;
using SAT_DAL.ContextInterface;
using SAT_DTO;
using SAT_DTO.BusinessObject;

namespace SAT_BAL.Repositories
{
    public class InventoryRepository : IInventoryRepository
    {
        IInventoryContext inventoryContext;
        public InventoryRepository()
        {
            inventoryContext = new InventoryContext();
        }
        public InventoryRepository(IInventoryContext contextObject)
        {
            inventoryContext = contextObject;
        }
        public ResponseBO<InventoryBO> AddInventory(InventoryBO inventoryBO)
        {
            return inventoryContext.AddInventory(inventoryBO);
        }

        public ResponseBO<InventoryBO> DeleteInventory(InventoryBO inventoryBO)
        {
            return inventoryContext.DeleteInventory(inventoryBO);
        }

        public ResponseBO<InventoryBO> DeleteInventory(int id)
        {
            return inventoryContext.DeleteInventory(id);
        }

        public IEnumerable<InventoryBO> GetAllInventory()
        {
            return inventoryContext.GetAllInventory();
        }

        public ResponseBO<InventoryBO> GetInventoryById(int id)
        {
            return inventoryContext.GetInventoryById(id);
        }

        public ResponseBO<InventoryBO> ModifyInventory(InventoryBO inventoryBO)
        {
            return inventoryContext.ModifyInventory(inventoryBO);
        }
    }
}
