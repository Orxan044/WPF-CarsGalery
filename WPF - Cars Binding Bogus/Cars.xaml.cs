using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Bogus;
using WPF___Cars_Binding_Bogus;

namespace WPF___Cars_Binding_Bogus
{

    public partial class Cars : Window
    {
        public List<Kia> Kia { get; set; }
        public List<Mercedes> Mercedess { get; set; }
        public List<Lada> Ladas { get; set; }
        public Cars()
        {
            InitializeComponent();
            DataContext = this;


            Kia = new List<Kia>
            {
                new Kia { Model = "Carnival", ImageUrl = $"https://cdn.motor1.com/images/mgl/q1kZJ/s1/1x1/2019-bmw-3-series-long-wheelbase.webp", Year = 2022 },
                new Kia { Model = "K5", ImageUrl = $"https://cdn.motor1.com/images/mgl/MRO7m/s1/1x1/2019-bmw-m5-competition.webp", Year = 2021 },
                new Kia { Model = "Optimal", ImageUrl = "https://cdn.motor1.com/images/mgl/Mk33e8/s1/1x1/bmw-z4-changes-side-by-side.webp", Year = 2023 }
            };

            Mercedess = new List<Mercedes>
            {
                new Mercedes { Model = "Mercedes-Benz S-Class", ImageUrl = $"https://m.media-amazon.com/images/W/IMAGERENDERING_521856-T1/images/I/61FMF8f5nQL._CR412,0,1060,1060_UX256.jpg", Year = 2022 },
                new Mercedes { Model = "Mercedes-Benz C-Class", ImageUrl = $"https://m1.secondhandapp.at/2.0/63c5581f9758846e7232a922?height=256&width=256", Year = 2021 },
                new Mercedes { Model = "Mercedes-Benz GLC-Class", ImageUrl = "https://m.media-amazon.com/images/W/IMAGERENDERING_521856-T1/images/I/71pQWDeS0aL._CR204,0,1224,1224_UX256.jpg", Year = 2023 }
            };

            Ladas = new List<Lada>
            {
                new Lada { Model = "Lada Vesta", ImageUrl = $"https://s.err.ee/photo/crop/2018/07/31/530308hfe8dt4.jpg", Year = 2022 },
                new Lada { Model = "Lada Granta", ImageUrl = $"https://avatars.mds.yandex.net/get-autoru-vos/1925516/8768f0f1de5a5b6c965a6eceeaf522ee/456x342", Year = 2021 },
                new Lada { Model = "Lada Niva", ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSo8FBSj7Xofjwx8dlqb1hCPjh1aA1gBAvDRA&usqp=CAU", Year = 2023 }
            };

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Masindir");
        }

        private void Rectangle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) => DragMove();
        private void ButtonClose_Click(object sender, RoutedEventArgs e) => Close();




    }
}
