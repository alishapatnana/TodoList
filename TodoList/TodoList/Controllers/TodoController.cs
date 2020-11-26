using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Models;
using TodoList.Repository;

namespace TodoList.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(TodoController));
        private ITodoRepository _service;
        public TodoController(ITodoRepository service)
        {
            _service = service;
        }
        [HttpGet]
        public ActionResult<List<TodoItem>> Get()
        {
            _log4net.Info("API initiated");
            _log4net.Info(" Http GET is accesed");
            return _service.GetAll();
        }

        [HttpPost]
        public ActionResult<TodoItem> Add(TodoItem item)
        {
            _log4net.Info("Post is accesed");
            _service.Add(item);
            return item;
        }

        [HttpPut]
        public ActionResult<TodoItem> Update(string id, TodoItem item)
        {
            _log4net.Info("Update is accesed");
            _service.Update(id, item);
            return item;
        }

        [HttpDelete]
        public ActionResult<string> Delete(string id)
        {
            _log4net.Info("Delete is accesed");
            _service.Remove(id);
            return id;
        }

    }
}
