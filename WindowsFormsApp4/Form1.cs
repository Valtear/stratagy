using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            MainStore ms = new MainStore();
            Food food = new Food();
            Clothes clothes = new Clothes();
            ms.Purchase(food);
            ms.Purchase(clothes);          
        }
    }

    class MainStore
    {
        public void Purchase(ITrade trading)
        {
            trading.Purchase();
        }

        public void Sale(ITrade trading)
        {
            trading.Sale();
        }    
    }

    interface ITrade
    {
        void Purchase();

        void Sale();
    }

    class Food : ITrade
    {
        public void Purchase()
        {
            MessageBox.Show("Food bought");
        }
        public void Sale()
        {
            MessageBox.Show("Food sold");
        }
    }

    class Clothes : ITrade
    {
        public void Purchase()
        {
            MessageBox.Show("Clothes bought");
        }
        public void Sale()
        {
            MessageBox.Show("Clothes sold");
        }
    }





}
