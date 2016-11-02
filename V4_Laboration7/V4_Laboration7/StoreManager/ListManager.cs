using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V4_Laboration7.StoreManager
{
    class ListManager
    {
        public static List<Product> ArtificialOrganCtg { get; set; }
        public static List<Product> ElectronicsCtg { get; set; }
        public static List<Product> UploadKnowledgeCtg { get; set; }

        static ListManager()
        {

            #region Artificial Organ Category
            ArtificialOrganCtg = new List<Product>()
            {

                new ArtificialOrgan()
                {
                    ProductName = "Heart",
                    Price = 1500,
                    Longevity = 10,
                    InStock = true,
                    ProductInformation = "This is a heart.",
                },

                new ArtificialOrgan()
                {
                    ProductName = "Kidney",
                    Price = 750,
                    Longevity = 15,
                    InStock = true,
                    ProductInformation = "This is a kidney.",
                },

                new ArtificialOrgan()
                {
                    ProductName = "Liver",
                    Price = 1250,
                    Longevity = 12,
                    InStock = false,
                    ProductInformation = "This is a liver."
                },

            };
            #endregion

            #region Electronics Category
            ElectronicsCtg = new List<Product>()
            {

                new Electronics()
                {
                    ProductName = "Hover Car",
                    Price = 5000,
                    InStock = true,
                    ProductInformation = "This is a Hover Car",
                    Weight = 2000,
                },

                new Electronics()
                {
                    ProductName = "Jet Pack",
                    Price = 650,
                    InStock = false,
                    ProductInformation = "This is a Jet Pack",
                    Weight = 20,
                },

                new Electronics()
                {
                    ProductName = "Hologram Projector",
                    Price = 120,
                    InStock = true,
                    ProductInformation = "This is a Hologram Projector",
                    Weight = 5,
                },

            };
            #endregion

            #region Upload Knowledge Category
            UploadKnowledgeCtg = new List<Product>()
            {

                new UploadKnowledge()
                {
                    ProductName = "Piano Skill",
                    Price = 60,
                    DataTransferTime = 30,
                    InStock = true,
                    ProductInformation = "This is a Piano Skill",
                },

                new UploadKnowledge()
                {
                    ProductName = "Math Skill",
                    Price = 20,
                    DataTransferTime = 60,
                    InStock = true,
                    ProductInformation = "This is a Math Skill",
                },

                new UploadKnowledge()
                {
                    ProductName = "Mandarin Skill",
                    Price = 30,
                    DataTransferTime = 120,
                    InStock = false,
                    ProductInformation = "This is a Mandarin Skill",
                },

            };
            #endregion

        }

        public static List<Product> ReturnCategory(int category)
        {

            switch (category)
            {
                case 1:
                    return ArtificialOrganCtg;
                case 2:
                    return ElectronicsCtg;
                case 3:
                    return UploadKnowledgeCtg;
            }

            return null;
        }
    }
}
