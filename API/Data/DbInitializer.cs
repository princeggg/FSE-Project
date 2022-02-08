using System.Collections.Generic;
using System.Linq;
using API.Entities;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initialize (StoreContext context)
        {
            if (context.Products.Any()) return;

            var products = new List<Product>
            {
                		new Product
                {
                    Name = "Dolo-650",
                    Description =
                        "Paracetamol, also known as acetaminophen, is a medication used to treat fever and mild to moderate pain. At a standard dose, paracetamol only slightly decreases body temperature",
                    Price = 20,
                    PictureUrl = "/images/products/1-dolo-650.png",
                    Brand = "Paracetamol",
                    Type = "Medicine",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Cetirizine",
                    Description = 
                        "Cetirizine is used to temporarily relieve the symptoms of hay fever and allergy to other substances (such as dust mites, animal dander, cockroaches, and molds).",
                    Price = 16,
                    PictureUrl = "/images/products/2-cetirizine.png",
                    Brand = "Zyrtec",
                    Type = "Medicine",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Saridon",
                    Description =
                        "Saridon tablet is a mild pain reliever that provides pain relief in as little as 30 minutes after consumption due to its unique triple-action formula.",
                    Price = 33,
                    PictureUrl = "/images/products/3-saridon.png",
                    Brand = "Saridon",
                    Type = "Medicine",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Ondansetron",
                    Description =
                        "Ondansetron blocks the actions of chemicals in the body that can trigger nausea and vomiting. Ondansetron is used to prevent nausea and vomiting that may be caused by surgery or radiation treatment.",
                    Price = 52,
                    PictureUrl = "/images/products/4-ondansetron.png",
                    Brand = "Zofran",
                    Type = "Medicine",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Crocin Advance",
                    Description =
                        "Crocin Advance Tablet 20's belongs to the group of mild analgesics , and antipyretic used to treat mild to moderate pain including headache, migraine, toothache, menstrual period pain, osteoarthritis pain, musculoskeletal pain, and reducing fever.",
                    Price = 18,
                    PictureUrl = "/images/products/5-crocin.png",
                    Brand = "Panadol",
                    Type = "Medicine",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "alprazolam",
                    Description =
                        "Alprazolam is used to treat anxiety and panic disorders. It belongs to a class of medications called benzodiazepines which act on the brain and nerves to produce a calming effect.",
                    Price = 28,
                    PictureUrl = "/images/products/6-Alprazolam.png",
                    Brand = "Xanax",
                    Type = "Medicine",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Aspirin",
                    Description =
                        "Aspirin is used to reduce fever and relieve mild to moderate pain from conditions such as muscle aches, toothaches, common cold, and headaches.",
                    Price = 3,
                    PictureUrl = "/images/products/7-Aspirin.png",
                    Brand = "Ecotrin",
                    Type = "Medicine",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Ibuprofen",
                    Description =
                        "Ibuprofen is used to relieve pain from various conditions such as headache, dental pain, menstrual cramps, muscle aches, or arthritis.",
                    Price = 30,
                    PictureUrl = "/images/products/8-Ibuprofen.png",
                    Brand = "Brufen",
                    Type = "Medicine",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Zedex SF",
                    Description =
                        "Zedex-SF Cough Syrup is a combination medicine used in the treatment of dry cough. It works by reducing the activity of cough center in the brain",
                    Price = 114,
                    PictureUrl = "/images/products/9-zedex.png",
                    Brand = "Zedex SF",
                    Type = "Syrup",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = " loperamide",
                    Description =
                        "Loperamide is used to treat diarrhea. Loperamide is also used to reduce the amount of stool in people who have an ileostomy.",
                    Price = 102,
                    PictureUrl = "/images/products/10-Loperamide.png",
                    Brand = "Diamode",
                    Type = "Medicine",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Amoxicillin ",
                    Description =
                        "Amoxicillin is used to treat a wide variety of bacterial infections. This medication is a penicillin-type antibiotic. It works by stopping the growth of bacteria.",
                    Price = 8,
                    PictureUrl = "/images/products/11-amoxicillin.png",
                    Brand = "Amoxil",
                    Type = "Medicine",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "DP gesic",
                    Description =
                        "DP Gesic Tablet 10's contains Diclofenac and Paracetamol (fever reducer/mild analgesic) effective against painful musculoskeletal pain, joint pain, and skeletal muscle spasms",
                    Price = 15,
                    PictureUrl = "/images/products/12-dp-gesic.png",
                    Brand = "Parafon Forte",
                    Type = "Medicine",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Combiflam",
                    Description =
                        "Combiflam Tablet contains two painkiller medicines. They work together to reduce pain, fever, and inflammation. It is used to treat many conditions such as headache, muscle pain, pain during periods, toothache, and joint pain.",
                    Price = 26,
                    PictureUrl = "/images/products/13-combiflam.png",
                    Brand = "Addaprin",
                    Type = "Medicine",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Belar",
                    Description =
                        "Belar Tablet 10's is available in oral, topical and injection and ophthalmic dosage forms. The oral and ophthalmic dosage forms of Belar Tablet 10's should be taken as prescribed by your doctor.",
                    Price = 5,
                    PictureUrl = "/images/products/14-belar.png",
                    Brand = "Betamethasone",
                    Type = "Medicine",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "Disprin",
                    Description =
                        "Disprin Regular 325mg Effervescent Tablet is used to treat many conditions such as headache, toothache, muscle pain, and fever.",
                    Price = 5,
                    PictureUrl = "/images/products/15-disprin.png",
                    Brand = "Aspirin",
                    Type = "Medicine",
                    QuantityInStock = 100
                },

            };

            foreach (var product in products)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();

        }
    }
}