﻿using BasicWeb.Data.Pages;
using Microsoft.AspNetCore.Mvc;
using Piranha;
using System;

namespace BasicWeb.Controllers
{
    public class CmsController : Controller
    {
        private readonly IApi api;

        /// <summary>
        /// Default constructor.
        /// </summary>
        /// <param name="api">The current api</param>
        public CmsController(IApi api) {
            this.api = api;
        }

        /// <summary>
        /// Gets the blog archive with the given id.
        /// </summary>
        /// <param name="id">The unique page id</param>
        /// <param name="year">The optional year</param>
        /// <param name="month">The optional month</param>
        /// <param name="page">The optional page</param>
        /// <param name="category">The optional category</param>
        /// <param name="tag">The optional tag</param>
        [Route("archive")]
        public IActionResult Archive(Guid id, int? year = null, int? month = null, int? page = null, 
            Guid? category = null, Guid? tag = null) 
        {
            BlogArchive model;

            if (category.HasValue)
                model = api.Archives.GetByCategoryId<BlogArchive>(id, category.Value, page, year, month);
            else if (tag.HasValue)
                model = api.Archives.GetByTagId<BlogArchive>(id, tag.Value, page, year, month);
            else model = api.Archives.GetById<BlogArchive>(id, page, year, month);

            return View(model);
        }

        /// <summary>
        /// Gets the page with the given id.
        /// </summary>
        /// <param name="id">The unique page id</param>
        [Route("page")]
        public IActionResult Page(Guid id) {
            var model = api.Pages.GetById<StandardPage>(id);

            return View(model);
        }

        /// <summary>
        /// Gets the post with the given id.
        /// </summary>
        /// <param name="id">The unique post id</param>
        [Route("post")]
        public IActionResult Post(Guid id) {
            var model = api.Posts.GetById<BlogPost>(id);

            return View(model);
        }

        /// <summary>
        /// Gets the startpage with the given id.
        /// </summary>
        /// <param name="id">The unique page id</param>
        [Route("start")]
        public IActionResult Start(Guid id) {
            var model = api.Pages.GetById<StartPage>(id);

            return View(model);
        }
    }
}
