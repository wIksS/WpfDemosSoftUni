using Shirts.Data;
using Shirts.Data.Repositories;
using Shirts.Models;
using System.Linq;
using System.Windows;

namespace Shirts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IRepository<Shirt> shirtsRepo;

        public MainWindow(IRepository<Shirt> shirtsRepo)
        {
            InitializeComponent();
            this.shirtsRepo = shirtsRepo;

            var shirts =shirtsRepo.All().ToList();
            foreach (var shirt in shirts)
            {
                Shirts.Items.Add(shirt.Model);
            }
        }

        public MainWindow() 
            : this(new SqlRepository<Shirt>("filename"))
        {

        }

        private void AddShirt(object sender, RoutedEventArgs e)
        {
            var newShirt = shirtsRepo.Add(new Shirt()
            {
                Model = Model.Text,
                Dirtiness = double.Parse(Dirtiness.Text),
                Manufacturer = Manufacturer.Text,
                Price = decimal.Parse(Price.Text)

            });

            shirtsRepo.SaveChanges();

            Shirts.Items.Add(newShirt.Model);


        }
    }
}
