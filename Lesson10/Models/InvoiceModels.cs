﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lesson10.Models
{
    public class InvoiceModel
    {
        public int InvoiceId { get; set; }
        public int CustomerId { get; set; }
        public DateTime InvoiceDate { get; set; }
        public decimal Total { get; set; }
    }

    public class AllInvoicesModel
    {
        public List<InvoiceModel> Invoices { get; set; }
    }
}