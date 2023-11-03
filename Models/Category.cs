﻿using LAB2_gaftone_delia.Migrations;

namespace LAB2_gaftone_delia.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string CategoryName {  get; set; }
        public ICollection<BookCategory>? BookCategories { get; set; }
    }
}
