﻿namespace FactsBee.Models
{
    public struct CategoryModel
    {
        public CategoryModel(string name, string image)
        {
            Name = name;
            Image = image;
        }

        public string Name { get; set; }
        public string Image { get; set; }

        public static IEnumerable<CategoryModel> GetCategories()
        {
            return new List<CategoryModel>
            {
                new CategoryModel("Animal", "animal.png"),
                new CategoryModel("Human", "human.png"),
                new CategoryModel("Entertainment", "entertainment.png"),
                new CategoryModel("Science & Technology", "science_technology.png"),
                new CategoryModel("Words & Languages", "word_language.png"),
                new CategoryModel("Misc", "misc.png"),
            };
        }

    }
}
