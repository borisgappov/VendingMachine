﻿//---------------------------------------------------------------------------//
//Разработчик: Гаппов Борис, gappov@gmail.com, +79262302992                  //
//Москва, 26.09.2014                                                         //
//---------------------------------------------------------------------------//
using System.Collections.Generic;

namespace VendingMachineCore
{
    /// <summary>
    /// Экспериментальные данные
    /// </summary>
    public class Samples
    {
        static List<ProductType> SampleProductTypes = new List<ProductType> { 
                        new ProductType { Id = 0, Name = "Чай", Price = 13 },
                        new ProductType { Id = 1, Name = "Кофе", Price = 18 },
                        new ProductType { Id = 2, Name = "Кофе с молоком", Price = 21 },
                        new ProductType { Id = 3, Name = "Сок", Price = 35 }
                    };


        # region Как в задании
        public static VendingMachine CreateSampleVendingMachine1()
        {
            var SampleMachine = new VendingMachine() { ProductTypes = SampleProductTypes };
            SampleMachine.Products.Add(0, 10);
            SampleMachine.Products.Add(1, 20);
            SampleMachine.Products.Add(2, 20);
            SampleMachine.Products.Add(3, 15);
            SampleMachine.Acceptor.Push(1, 100);
            SampleMachine.Acceptor.Push(2, 100);
            SampleMachine.Acceptor.Push(5, 100);
            SampleMachine.Acceptor.Push(10, 100);
            return SampleMachine;
        }

        public static Customer CreateSampleCustomer1()
        {
            var SampleCustomer = new Customer();
            SampleCustomer.Purse.Push(1, 10);
            SampleCustomer.Purse.Push(2, 30);
            SampleCustomer.Purse.Push(5, 20);
            SampleCustomer.Purse.Push(10, 15);
            return SampleCustomer;
        }
        #endregion

        # region Небольшое количество денег автомате
        public static VendingMachine CreateSampleVendingMachine2()
        {
            var SampleMachine = new VendingMachine() { ProductTypes = SampleProductTypes };
            SampleMachine.Products.Add(0, 10);
            SampleMachine.Products.Add(1, 10);
            SampleMachine.Products.Add(2, 10);
            SampleMachine.Products.Add(3, 10);
            SampleMachine.Acceptor.Push(1, 1);
            SampleMachine.Acceptor.Push(2, 1);
            SampleMachine.Acceptor.Push(5, 1);
            SampleMachine.Acceptor.Push(10, 1);
            return SampleMachine;
        }

        public static Customer CreateSampleCustomer2()
        {
            var SampleCustomer = new Customer();
            SampleCustomer.Purse.Push(1, 1);
            SampleCustomer.Purse.Push(2, 1);
            SampleCustomer.Purse.Push(5, 1);
            SampleCustomer.Purse.Push(10, 20);
            return SampleCustomer;
        }
        #endregion

        # region Экзотические монеты
        public static VendingMachine CreateSampleVendingMachine3()
        {
            var SampleMachine = new VendingMachine() { ProductTypes = SampleProductTypes };
            SampleMachine.Products.Add(0, 3);
            SampleMachine.Products.Add(1, 2);
            SampleMachine.Products.Add(2, 4);
            SampleMachine.Products.Add(3, 5);
            SampleMachine.Acceptor.Push(1, 3);
            SampleMachine.Acceptor.Push(3, 2);
            SampleMachine.Acceptor.Push(7, 4);
            SampleMachine.Acceptor.Push(11, 3);
            return SampleMachine;
        }

        public static Customer CreateSampleCustomer3()
        {
            var SampleCustomer = new Customer();
            SampleCustomer.Purse.Push(1, 5);
            SampleCustomer.Purse.Push(3, 3);
            SampleCustomer.Purse.Push(7, 3);
            SampleCustomer.Purse.Push(11, 3);
            return SampleCustomer;
        }
        #endregion

    }
}
