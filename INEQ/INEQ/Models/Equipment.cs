﻿
using System;
using System.Collections.Generic;
using INEQ.Models;
using System.Linq;
using System.Web;

namespace INEQ.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        public DateTime EntryDate { get; set; }
        public String Serie { get; set; }
        public String Softtekld { get; set; }
        public bool Active { get; set; }

        public int EquipmentTypeld  { get; set; }
        public int Modelld  { get; set; }
        public int Brandld  { get; set; }
        public int Statusld  { get; set; }
        public int Warehouseld  { get; set; }

        public virtual ICollection<Warehouse> Warehouses { get; set; }
      
        }
}