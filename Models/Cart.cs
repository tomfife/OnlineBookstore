﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineBookstore.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        public virtual void AddItem(Book book, int qty)
        {
            CartLine line = Lines
                .Where(b => b.Book.BookId == book.BookId)
                .FirstOrDefault();

            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    Book = book,
                    Quantity = qty
                });
            }
            else
            {
                line.Quantity += qty;
            }
        }

        public class CartLine
        {
            public int CartLineID { get; set; }

            public Book Book { get; set; }

            public int Quantity { get; set; }
        }

        public virtual void RemoveLine(Book book) =>
            Lines.RemoveAll(x => x.Book.BookId == book.BookId);

        public virtual void Clear() => Lines.Clear();

        public double ComputeTotalSum() =>
            Lines.Sum(e => e.Book.BookPrice * e.Quantity);
    }
}
