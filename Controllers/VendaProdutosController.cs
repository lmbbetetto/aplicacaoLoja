﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using aplicacaoLoja.Models;

namespace aplicacaoLoja.Controllers
{
    public class VendaProdutosController : Controller
    {
        private readonly Contexto _context;

        public VendaProdutosController(Contexto context)
        {
            _context = context;
        }

        // GET: VendaProdutos
        public async Task<IActionResult> Index()
        {
            var contexto = _context.VendaProduto.Include(v => v.produto);
            return View(await contexto.ToListAsync());
        }

        // GET: VendaProdutos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.VendaProduto == null)
            {
                return NotFound();
            }

            var vendaProduto = await _context.VendaProduto
                .Include(v => v.produto)
                .FirstOrDefaultAsync(m => m.id == id);
            if (vendaProduto == null)
            {
                return NotFound();
            }

            return View(vendaProduto);
        }

        // GET: VendaProdutos/Create
        public IActionResult Create()
        {
            ViewData["produtoID"] = new SelectList(_context.Produtos, "id", "descricao");
            return View();
        }

        // POST: VendaProdutos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,produtoID,quantidade")] VendaProduto vendaProduto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vendaProduto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["produtoID"] = new SelectList(_context.Produtos, "id", "descricao", vendaProduto.produtoID);
            return View(vendaProduto);
        }

        // GET: VendaProdutos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.VendaProduto == null)
            {
                return NotFound();
            }

            var vendaProduto = await _context.VendaProduto.FindAsync(id);
            if (vendaProduto == null)
            {
                return NotFound();
            }
            ViewData["produtoID"] = new SelectList(_context.Produtos, "id", "descricao", vendaProduto.produtoID);
            return View(vendaProduto);
        }

        // POST: VendaProdutos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,produtoID,quantidade")] VendaProduto vendaProduto)
        {
            if (id != vendaProduto.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vendaProduto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VendaProdutoExists(vendaProduto.id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["produtoID"] = new SelectList(_context.Produtos, "id", "descricao", vendaProduto.produtoID);
            return View(vendaProduto);
        }

        // GET: VendaProdutos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.VendaProduto == null)
            {
                return NotFound();
            }

            var vendaProduto = await _context.VendaProduto
                .Include(v => v.produto)
                .FirstOrDefaultAsync(m => m.id == id);
            if (vendaProduto == null)
            {
                return NotFound();
            }

            return View(vendaProduto);
        }

        // POST: VendaProdutos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.VendaProduto == null)
            {
                return Problem("Entity set 'Contexto.VendaProduto'  is null.");
            }
            var vendaProduto = await _context.VendaProduto.FindAsync(id);
            if (vendaProduto != null)
            {
                _context.VendaProduto.Remove(vendaProduto);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VendaProdutoExists(int id)
        {
          return _context.VendaProduto.Any(e => e.id == id);
        }
    }
}
