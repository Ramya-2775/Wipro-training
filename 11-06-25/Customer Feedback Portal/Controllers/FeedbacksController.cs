﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Customer_Feedback_Portal.Data;
using Customer_Feedback_Portal.Models;
using Microsoft.AspNetCore.Http;

namespace Customer_Feedback_Portal.Controllers
{
    public class FeedbacksController : Controller
    {
        private readonly Customer_Feedback_PortalContext _context;

        public FeedbacksController(Customer_Feedback_PortalContext context)
        {
            _context = context;
        }

        // GET: Feedbacks
        public async Task<IActionResult> Index()
        {
            return View(await _context.Feedback.ToListAsync());
        }

        // GET: Feedbacks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var feedback = await _context.Feedback.FirstOrDefaultAsync(m => m.Id == id);
            if (feedback == null)
                return NotFound();

            return View(feedback);
        }

        // GET: Feedbacks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Feedbacks/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Email,Rating,Message,Submittedon")] Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                _context.Add(feedback);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(feedback);
        }

        // GET: Feedbacks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (HttpContext.Session.GetString("Admin") != "true")
                return RedirectToAction("Login", "Admin");

            if (id == null)
                return NotFound();

            var feedback = await _context.Feedback.FindAsync(id);
            if (feedback == null)
                return NotFound();

            return View(feedback);
        }

        // POST: Feedbacks/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Email,Rating,Message,Submittedon")] Feedback feedback)
        {
            if (HttpContext.Session.GetString("Admin") != "true")
                return RedirectToAction("Login", "Admin");

            if (id != feedback.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(feedback);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FeedbackExists(feedback.Id))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(feedback);
        }

        // GET: Feedbacks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (HttpContext.Session.GetString("Admin") != "true")
                return RedirectToAction("Login", "Admin");

            if (id == null)
                return NotFound();

            var feedback = await _context.Feedback.FirstOrDefaultAsync(m => m.Id == id);
            if (feedback == null)
                return NotFound();

            return View(feedback);
        }

        // POST: Feedbacks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (HttpContext.Session.GetString("Admin") != "true")
                return RedirectToAction("Login", "Admin");

            var feedback = await _context.Feedback.FindAsync(id);
            if (feedback != null)
            {
                _context.Feedback.Remove(feedback);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FeedbackExists(int id)
        {
            return _context.Feedback.Any(e => e.Id == id);
        }
    }
}