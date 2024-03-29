﻿using FactsBee.Data;
using FactsBee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactsBee.ViewModels
{
    public class MainViewModel
    {
        public FactModel FactOfTheDay { get; set; }
        public IEnumerable<CategoryModel> Categories { get; set; }
        public IEnumerable<FactModel> RandomFacts { get; set; }

        public MainViewModel()
        {
            Categories = CategoryModel.GetCategories();

            FactOfTheDay = FactsData.GetFactOfTheDay();

            RandomFacts = FactsData.GetRandomFacts();
        }
    }
}
