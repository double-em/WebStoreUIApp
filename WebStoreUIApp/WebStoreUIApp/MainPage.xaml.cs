using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebStoreUIApp.Models;
using Xamarin.Forms;

namespace WebStoreUIApp
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Product> Products = new ObservableCollection<Product>()
        {
            new Product
            {
                Name = "Belt - Size 'DAAMN'",
                Price = 999.00,
                ImagePath = "belt.jpg"
            },
            new Product
            {
                Name = "Divorced Dad Hat",
                Price = 420.00,
                ImagePath = "hat.jpg"
            },
            new Product
            {
                Name = "Divorced Dad Hat",
                Price = 420.00,
                ImagePath = "hat.jpg"
            },
            new Product
            {
                Name = "Divorced Dad Hat",
                Price = 420.00,
                ImagePath = "hat.jpg"
            },
            new Product
            {
                Name = "Divorced Dad Hat",
                Price = 420.00,
                ImagePath = "hat.jpg"
            },
            new Product
            {
                Name = "Divorced Dad Hat",
                Price = 420.00,
                ImagePath = "hat.jpg"
            },
            new Product
            {
                Name = "Slap Your Son!",
                Price = 69.00,
                ImagePath = "belt.jpg"
            },
            new Product
            {
                Name = "Divorced Dad Hat",
                Price = 420.00,
                ImagePath = "hat.jpg"
            },
            new Product
            {
                Name = "Divorced Dad Hat",
                Price = 420.00,
                ImagePath = "hat.jpg"
            }
        };

        public ObservableCollection<ProductsPairs> ProductPairs { get; set; } =
            new ObservableCollection<ProductsPairs>();
        
        public MainPage()
        {
            InitializeComponent();
            CreateModelPairs();
        }

        private void CreateModelPairs()
        {
            for (int i = 0; i < Products.Count; i += 2)
            {
                Product item1 = Products[i];
                Product item2 = i + 1 < Products.Count ? Products[i + 1] : null;
                
                ProductPairs.Add(new ProductsPairs(item1, item2));
            }
        }
    }
}