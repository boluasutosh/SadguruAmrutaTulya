using SAT_DAL.ContextInterface;
using SAT_DTO.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAT_DAL.ContextClass
{
    class InventoryContext : IInventory
    {
        private dbSadguruAmrutatulyaEntities _context;
        public InventoryContext()
        {
            _context = new dbSadguruAmrutatulyaEntities();
        }
        public ResponseBO<InventoryBO> AddInventory(InventoryBO inventoryBO)
        {
            ResponseBO<InventoryBO> responseBO = new ResponseBO<InventoryBO>();
            try
            {
                responseBO.ReturnedObject =  _context.Inventories.Add(inventoryBO.InventoryOTB()).InventoryDTO();
                responseBO.IsSuccess = true;
                responseBO.ResponseMessage = "Successfully Inserted Inventory";

                return responseBO;
            }
            catch(Exception e)
            {
                responseBO.IsSuccess = false;
                responseBO.ResponseMessage = e.InnerException.ToString();
                return responseBO;
            }
            
        }

        public bool DeleteInventory(InventoryBO inventoryBO)
        {
            throw new NotImplementedException();
        }

        public List<InventoryBO> GetAllInventory()
        {
            throw new NotImplementedException();
        }

        public InventoryBO GetInventoryById(int id)
        {
            throw new NotImplementedException();
        }

        public InventoryBO ModifyInventory(InventoryBO inventoryBO)
        {
            throw new NotImplementedException();
        }
    }
}
