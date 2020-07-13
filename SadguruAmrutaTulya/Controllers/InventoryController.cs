using SAT_BAL.IRepositories;
using SAT_BAL.Repositories;
using SAT_DTO.BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace SadguruAmrutaTulya.Controllers
{
    public class InventoryController : ApiController
    {
        private IInventoryRepository inventoryRepository;

        public InventoryController()
        {
            inventoryRepository = new InventoryRepository();
        }
        public IHttpActionResult GetAllInventory()
        {
            IEnumerable<InventoryBO> inventories = inventoryRepository.GetAllInventory();
            if(inventories != null)
            {
                return Ok<IEnumerable<InventoryBO>>(inventories);
            }
            else
            {
                return Content(HttpStatusCode.NotFound, "Nothing Found");
            }
            
        }

        public IHttpActionResult GetInventoryById([FromUri]int id)
        {
            ResponseBO<InventoryBO> response = inventoryRepository.GetInventoryById(id);
            if (response.IsSuccess)
            {
                return Ok<InventoryBO>(response.ReturnedObject);
            }
            else
            {
                return Content(HttpStatusCode.NotFound, "Unable to add inventory");
            }

        }

        public IHttpActionResult AddInventory([FromBody]InventoryBO inventoryBO)
        {
            ResponseBO<InventoryBO> response = inventoryRepository.AddInventory(inventoryBO);
            if (response.IsSuccess)
            {
                return Ok<InventoryBO>(response.ReturnedObject);
            }
            else
            {
                return Content(HttpStatusCode.NotFound, "Unable to add inventory");
            }
        }

        [HttpPut]
        public IHttpActionResult ModifyInventory([FromBody]InventoryBO inventoryBO)
        {
            ResponseBO<InventoryBO> response = inventoryRepository.ModifyInventory(inventoryBO);
            if (response.IsSuccess)
            {
                return Ok<InventoryBO>(response.ReturnedObject);
            }
            else
            {
                return Content(HttpStatusCode.NotFound, "Unable to Modify inventory");
            }
        }

        [HttpDelete]
        public IHttpActionResult DeleteInventory([FromBody]InventoryBO inventoryBO)
        {
            ResponseBO<InventoryBO> response = inventoryRepository.DeleteInventory(inventoryBO);
            if (response.IsSuccess)
            {
                return Ok<InventoryBO>(response.ReturnedObject);
            }
            else
            {
                return Content(HttpStatusCode.NotFound, "Unable to Delete inventory");
            }
        }

        [HttpDelete]
        public IHttpActionResult DeleteInventory(int id)
        {
            ResponseBO<InventoryBO> response = inventoryRepository.DeleteInventory(id);
            if (response.IsSuccess)
            {
                return Ok<InventoryBO>(response.ReturnedObject);
            }
            else
            {
                return Content(HttpStatusCode.NotFound, "Unable to Delete inventory");
            }

        }



    }
}
