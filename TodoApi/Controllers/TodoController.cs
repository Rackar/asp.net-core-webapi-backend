﻿using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly TodoContext _context;

        public TodoController(TodoContext context)
        {
            _context = context;

            if (_context.TodoItems.Count() == 0)
            {
                // Create a new TodoItem if collection is empty,
                // which means you can't delete all TodoItems.
                _context.TodoItems.Add(new TodoItem { UploadFileName = "Item1" });
                _context.SaveChanges();
            }
        }
        [HttpGet]
        public ActionResult<List<TodoItem>> GetAll()
        {
            return _context.TodoItems.ToList();
        }

        [HttpGet("{gid}", Name = "GetTodo")]
        public ActionResult<TodoItem> GetById(long gid)
        {
            var item = _context.TodoItems.Find(gid);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }
    }
   
}