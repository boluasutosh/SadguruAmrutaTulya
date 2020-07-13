using SAT_DAL.ContextInterface;
using SAT_DTO.BusinessObject;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAT_DAL.ContextClass
{
    public class InventoryContext : IInventoryContext
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
                Inventory inventory  =  _context.Inventories.Add(inventoryBO.ToInventoryOTB());
                _context.SaveChanges();
                responseBO.ReturnedObject = inventory.ToInventoryDTO(); 
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

        public ResponseBO<InventoryBO> DeleteInventory(InventoryBO inventoryBO)
        {
            ResponseBO<InventoryBO> responseBO = new ResponseBO<InventoryBO>();
            try
            {
                Inventory inventory = _context.Inventories.Remove(FindElementByID(inventoryBO.Id));
                _context.SaveChanges();
               responseBO.ReturnedObject = inventory.ToInventoryDTO();
                responseBO.IsSuccess = true;
                responseBO.ResponseMessage = "Successfully deleted the inventory";
                return responseBO;
            }
            catch(Exception e)
            {
                responseBO.IsSuccess = false;
                responseBO.ResponseMessage = e.InnerException.ToString();
                return responseBO;
            }
        }

        public ResponseBO<InventoryBO> DeleteInventory(int id)
        {
            ResponseBO<InventoryBO> responseBO = new ResponseBO<InventoryBO>();
            try
            {
                Inventory inventory = _context.Inventories.Remove(FindElementByID(id));
                _context.SaveChanges();
                responseBO.ReturnedObject = inventory.ToInventoryDTO();
                responseBO.IsSuccess = true;
                responseBO.ResponseMessage = "Successfully deleted the inventory";
                return responseBO;
            }
            catch(Exception e)
            {
                responseBO.IsSuccess = false;
                responseBO.ResponseMessage = e.InnerException.ToString();
                return responseBO;
            }
        }

        public IEnumerable<InventoryBO> GetAllInventory()
        {
            //return _context.Inventories.Select(inventory=>inventory.ToInventoryDTO()).ToList();
            return _context.Inventories.ToList().Select(inventory => inventory.ToInventoryDTO());
        }

        public ResponseBO<InventoryBO> GetInventoryById(int id)
        {
            ResponseBO<InventoryBO> responseBO = new ResponseBO<InventoryBO>();
            try
            {
                responseBO.ReturnedObject = FindElementByID(id).ToInventoryDTO();
                responseBO.IsSuccess = true;
                responseBO.ResponseMessage = "Successfully got the inventory";
                return responseBO;
            }
            catch(Exception e)
            {
                responseBO.IsSuccess = false;
                responseBO.ResponseMessage = e.InnerException.ToString();
                return responseBO;
            }
        }

        public ResponseBO<InventoryBO> ModifyInventory(InventoryBO inventoryBO)
        {
            ResponseBO<InventoryBO> responseBO = new ResponseBO<InventoryBO>();
            try
            {
                _context.Entry(inventoryBO.ToInventoryOTB()).State = EntityState.Modified;
                _context.SaveChanges();
                responseBO.ReturnedObject = FindElementByID(inventoryBO.Id).ToInventoryDTO();
                responseBO.IsSuccess = true;
                responseBO.ResponseMessage = "Successfully Modified the inventory";
                return responseBO;
            }
            catch (Exception e)
            {
                responseBO.IsSuccess = false;
                responseBO.ResponseMessage = e.InnerException.ToString();
                return responseBO;
            }
        }

        private Inventory FindElementByID(int id)
        {
            return _context.Inventories.Find(id);
        }

    }
}
