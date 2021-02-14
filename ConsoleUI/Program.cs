using Business.Concrete;
using Business.Constants;
using DataAccess.Abstract;
using DataAccess.Concrete.Entity_Framework;
using Entities.Concrete;
using System;


namespace ConsoleUICore
{
    public class Program
    {
        private static void Context()
        {
            string sec;

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.WriteLine(" 1) AUTHORIZED");
            Console.WriteLine(" 2) ADMIN");
            Console.WriteLine(" 3) CUSTOMER");
            Console.WriteLine(" 4) PRODUCT");
            Console.WriteLine(" 5) BUYERPROJECT");
            Console.WriteLine(" 6) REGION");
            sec = Console.ReadLine();


            if (sec == "1")
            {
                string seccontex;
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.Clear();
                Console.WriteLine(" SELECT ACTION ");
                Console.WriteLine(" 1) ADD ");
                Console.WriteLine(" 2) DELETE ");
                Console.WriteLine(" 3) UPDATE ");
                Console.WriteLine(" 4) LIST ");
                Console.WriteLine(" 5) GO HOME BACK ");
                seccontex = Console.ReadLine();


                if (seccontex == "1")
                {
                    string Name, Surname, Salary, DateofStart, DateofOut;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Clear();
                    Console.Write("Authorized Name:  ");
                    Name = Console.ReadLine();
                    Console.Write("Authorized Surname:  ");
                    Surname = Console.ReadLine();
                    Console.Write("Authorized Salary:  ");
                    Salary = Console.ReadLine();
                    Console.Write("Authorized DateofStart:  ");
                    DateofStart = Console.ReadLine();
                    Console.Write("Authorized DateofOut:  ");
                    DateofOut = Console.ReadLine();

                    Console.Clear();
                    Console.WriteLine(Messages.LoadingList);

                    AuthorizedManager authorizedManager = new AuthorizedManager(new EfAuthorizedDAL());
                    authorizedManager.Add(new Authorized
                    {
                        AuthorizedName = Name,
                        AuthorizedSurname = Surname,
                        AuthorizedSalary = Convert.ToInt32(Salary.ToString()),
                        AuthorizedDateofStart = Convert.ToInt32(DateofStart.ToString()),
                        AuthorizedDateofOut = Convert.ToInt32(DateofOut.ToString())

                    });
                    Console.WriteLine(Messages.Succes);
                }

                else if (seccontex == "2")
                {
                    AuthorizedManager authorizedManager = new AuthorizedManager(new EfAuthorizedDAL());
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.Clear();
                    foreach (var item in authorizedManager.GetAll().Data)
                    {
                        Console.WriteLine(item.IdentificationNumber.ToString() + ")" + item.AuthorizedName + "\n");
                    }
                    string IdentificationNumber;

                    Console.Write("IdentificationNumber : ");
                    IdentificationNumber = Console.ReadLine();


                    authorizedManager.Delete(new Authorized { IdentificationNumber = Convert.ToInt32(IdentificationNumber.ToString()) });
                    Console.WriteLine(Messages.Succes);

                }

                else if (seccontex == "3")
                {
                    AuthorizedManager authorizedManager = new AuthorizedManager(new EfAuthorizedDAL());
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Clear();
                    foreach (var item in authorizedManager.GetAll().Data)
                    {
                        Console.WriteLine(item.IdentificationNumber.ToString() + ")" + item.AuthorizedName + "\n");
                    }
                    string Name, Surname, Salary, DateofStart, DateofOut, IdentificationNumber;

                    Console.Write("Authorized IdentificationNumber:  ");
                    IdentificationNumber = Console.ReadLine();
                    Console.Write("Authorized Name:  ");
                    Name = Console.ReadLine();
                    Console.Write("Authorized Surname:  ");
                    Surname = Console.ReadLine();
                    Console.Write("Authorized Salary:  ");
                    Salary = Console.ReadLine();
                    Console.Write("Authorized DateofStart:  ");
                    DateofStart = Console.ReadLine();
                    Console.Write("Authorized DateofOut:  ");
                    DateofOut = Console.ReadLine();


                    authorizedManager.Update(new Authorized
                    {
                        IdentificationNumber = Convert.ToInt32(IdentificationNumber.ToString()),
                        AuthorizedName = Name,
                        AuthorizedSurname = Surname,
                        AuthorizedSalary = Convert.ToInt32(Salary.ToString()),
                        AuthorizedDateofStart = Convert.ToInt32(DateofStart.ToString()),
                        AuthorizedDateofOut = Convert.ToInt32(DateofOut.ToString())
                    });
                    Console.WriteLine(Messages.Succes);

                }

                else if (seccontex == "4")
                {
                    AuthorizedManager authorizedManager = new AuthorizedManager(new EfAuthorizedDAL());
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.WriteLine(Messages.LoadingList);
                    foreach (var item in authorizedManager.GetAll().Data)

                    {
                        Console.WriteLine(item.IdentificationNumber.ToString() + ")" + " Authorized Name: " + item.AuthorizedName + " | AutorizedSurname: " + item.AuthorizedSurname);

                    }
                    Console.WriteLine(Messages.Succes);

                }

                else if (seccontex == "5")
                {
                    Context();

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    Console.WriteLine(Messages.Error + "\n\n\n");
                }


            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.WriteLine(Messages.Error + "\n\n\n");

            }
            if (sec == "2")
            {
                string seccontex;
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.Clear();

                Console.WriteLine(" 1) ADD ");
                Console.WriteLine(" 2) DELETE ");
                Console.WriteLine(" 3) UPDATE ");
                Console.WriteLine(" 4) LIST ");
                Console.WriteLine(" 5) GO HOME BACK");
                seccontex = Console.ReadLine();
                if (seccontex == "1")
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Clear();
                    string name, passw;
                    Console.Write(" NAME :  ");
                    name = Console.ReadLine();
                    Console.Write(" PASW :  ");
                    passw = Console.ReadLine();

                    Console.Clear();
                    Console.WriteLine(Messages.LoadingList);

                    AdminManager adminManager = new AdminManager(new EfAdminDAL());
                    adminManager.Add(new Admin { Name = name, Passw = passw });
                    Console.WriteLine(Messages.Succes);
                }
                else if (seccontex == "2")
                {
                    AdminManager adminManager = new AdminManager(new EfAdminDAL());
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.Clear();
                    foreach (var item in adminManager.GetAll().Data)
                    {
                        Console.WriteLine(item.AdminID + ") " + item.Name);
                    }
                    string adminid;
                    Console.Write(" ADMINID :");
                    adminid = Console.ReadLine();
                    adminManager.Delete(new Admin { AdminID = Convert.ToInt32(adminid.ToString()) });
                    Console.WriteLine(Messages.Succes);

                }
                else if (seccontex == "3")
                {
                    AdminManager adminManager = new AdminManager(new EfAdminDAL());
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Clear();
                    foreach (var item in adminManager.GetAll().Data)
                    {
                        Console.WriteLine(item.AdminID + ")" + item.Name);
                    }
                    string adminid, name, passw;
                    Console.Write(" ADMINID : ");
                    adminid = Console.ReadLine();
                    Console.Write(" NAME :  ");
                    name = Console.ReadLine();
                    Console.Write(" PASW :  ");
                    passw = Console.ReadLine();

                    adminManager.Update(new Admin { Name = name, Passw = passw, AdminID = Convert.ToInt32(adminid.ToString()) });
                    Console.WriteLine(Messages.Succes);
                }
                else if (seccontex == "4")
                {
                    AdminManager adminManager = new AdminManager(new EfAdminDAL());
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.WriteLine(Messages.LoadingList);
                    foreach (var item in adminManager.GetAll().Data)
                    {
                        Console.WriteLine(item.AdminID + ")" + " Name: " + item.Name + " | Passw: " + item.Passw);
                    }
                    Console.WriteLine(Messages.Listing);
                }
                else if (seccontex == "5")
                {
                    Context();
                }


            }
            if (sec == "3")
            {
                string seccontex;
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.Clear();

                Console.WriteLine(" 1) ADD ");
                Console.WriteLine(" 2) DELETE ");
                Console.WriteLine(" 3) UPDATE ");
                Console.WriteLine(" 4) LIST ");
                Console.WriteLine(" 5) GO HOME BACK ");
                seccontex = Console.ReadLine();
                if (seccontex == "1")
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Clear();
                    string name, surname, telephone, mail;
                    Console.Write(" NAME :  ");
                    name = Console.ReadLine();
                    Console.Write(" SURNAME :  ");
                    surname = Console.ReadLine();
                    Console.Write(" MAIL : ");
                    mail = Console.ReadLine();
                    Console.Write(" TELEPHONE : ");
                    telephone = Console.ReadLine();

                    Console.Clear();
                    Console.WriteLine(Messages.LoadingList);
                    CustomerRegistrationManager customerRegistrationManager = new CustomerRegistrationManager(new EfCustomerRegistrationDAL());
                    customerRegistrationManager.Add(new CustomerRegistration
                    {
                        NewCustomerName = name,
                        NewCustomerSurname = surname,
                        Mail = mail,
                        NewCustomerTelephoneNo = Convert.ToInt32(telephone.ToString())
                    });

                }
                else if (seccontex == "2")
                {
                    CustomerRegistrationManager customerRegistrationManager = new CustomerRegistrationManager(new EfCustomerRegistrationDAL());
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.Clear();
                    foreach (var item in customerRegistrationManager.GetAll().Data)
                    {
                        Console.WriteLine(item.NewCustomerId + ")" + item.NewCustomerName + " " + item.NewCustomerSurname);
                    };
                    string customerid;
                    Console.Write(" CUSTOMERID : ");
                    customerid = Console.ReadLine();
                    customerRegistrationManager.Delete(new CustomerRegistration
                    {
                        NewCustomerId = Convert.ToInt32(customerid.ToString())
                    });
                    Console.WriteLine(Messages.Succes);
                }
                else if (seccontex == "3")
                {
                    CustomerRegistrationManager customerRegistrationManager = new CustomerRegistrationManager(new EfCustomerRegistrationDAL());
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Clear();
                    foreach (var item in customerRegistrationManager.GetAll().Data)
                    {
                        Console.WriteLine(item.NewCustomerId.ToString() + ")" + item.NewCustomerName + "\n");

                    }
                    string name, surname, telephone, mail, Customerid;

                    Console.Write(" CUSTOMER ID: ");
                    Customerid = Console.ReadLine();
                    Console.Write(" NAME :  ");
                    name = Console.ReadLine();
                    Console.Write(" SURNAME :  ");
                    surname = Console.ReadLine();
                    Console.Write(" MAIL : ");
                    mail = Console.ReadLine();
                    Console.Write(" TELEPHONE : ");
                    telephone = Console.ReadLine();
                    customerRegistrationManager.Update(new CustomerRegistration { NewCustomerId = Convert.ToInt32(Customerid.ToString()), NewCustomerName = name, NewCustomerSurname = surname, NewCustomerTelephoneNo = Convert.ToInt32(telephone.ToString()) });
                    Console.WriteLine(Messages.Succes);

                }
                else if (seccontex == "4")
                {
                    CustomerRegistrationManager customerRegistrationManager = new CustomerRegistrationManager(new EfCustomerRegistrationDAL());
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.WriteLine(Messages.LoadingList);

                    foreach (var item in customerRegistrationManager.GetAll().Data)
                    {
                        Console.WriteLine(item.NewCustomerId.ToString() + ")" + " Customer Name: " + item.NewCustomerName + " | Customer Surname: " + item.NewCustomerSurname + " | Customer Mail: " + item.Mail);

                    }
                    Console.WriteLine(Messages.Listing);
                }
                else if (seccontex == "5")
                {
                    Context();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    Console.WriteLine(Messages.Error + "\n\n\n");

                }
            }
            if (sec == "4")
            {
                string seccontex;
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.Clear();

                Console.WriteLine(" 1) ADD ");
                Console.WriteLine(" 2) DELETE ");
                Console.WriteLine(" 3) UPDATE ");
                Console.WriteLine(" 4) LIST ");
                Console.WriteLine(" 5) GO HOME BACK ");
                seccontex = Console.ReadLine();
                if (seccontex == "1")
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Clear();
                    string name, price, image, quantity;
                    Console.Write(" PRODUCT NAME :  ");
                    name = Console.ReadLine();
                    Console.Write(" PRICE :  ");
                    price = Console.ReadLine();
                    Console.Write(" QUANTITY : ");
                    quantity = Console.ReadLine();
                    Console.Write(" IMAGE : ");
                    image = Console.ReadLine();

                    Console.Clear();
                    Console.WriteLine(Messages.LoadingList);
                    ProductRegistrationManager productRegistrationManager = new ProductRegistrationManager(new EfProductRegistrationDAL());
                    productRegistrationManager.Add(new ProductRegistration
                    {
                        NewProductName = name,
                        NewProductPrice = Convert.ToInt32(price.ToString()),
                        NewProductQuantity = Convert.ToInt32(quantity.ToString()),
                        NewProductImage = image
                    });
                }
                else if (seccontex == "2")
                {
                    ProductRegistrationManager productRegistrationManager = new ProductRegistrationManager(new EfProductRegistrationDAL());
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.Clear();
                    foreach (var item in productRegistrationManager.GetAll().Data)
                    {
                        Console.WriteLine(item.NewProductId + ")" + item.NewProductName + " " + item.NewProductImage);
                    };
                    string productid;
                    Console.Write(" PRODUCTID : ");
                    productid = Console.ReadLine();
                    productRegistrationManager.Delete(new ProductRegistration
                    {
                        NewProductId = Convert.ToInt32(productid.ToString())
                    });
                    Console.WriteLine(Messages.Succes);
                }
                else if (seccontex == "3")
                {
                    ProductRegistrationManager productRegistrationManager = new ProductRegistrationManager(new EfProductRegistrationDAL());
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Clear();
                    foreach (var item in productRegistrationManager.GetAll().Data)
                    {
                        Console.WriteLine(item.NewProductId.ToString() + ")" + item.NewProductName + "\n");

                    }
                    string name, price, image, quantity, productid;

                    Console.Write(" PRODUCT ID: ");
                    productid = Console.ReadLine();
                    Console.Write(" NAME :  ");
                    name = Console.ReadLine();
                    Console.Write(" PRICE :  ");
                    price = Console.ReadLine();
                    Console.Write(" QUANTITY : ");
                    quantity = Console.ReadLine();
                    Console.Write(" IMAGE : ");
                    image = Console.ReadLine();
                    productRegistrationManager.Update(new ProductRegistration { NewProductId = Convert.ToInt32(productid.ToString()), NewProductName = name, NewProductPrice = Convert.ToInt32(price.ToString()), NewProductQuantity = Convert.ToInt32(quantity.ToString()), NewProductImage = image });
                    Console.WriteLine(Messages.Succes);
                }
                else if (seccontex == "4")
                {
                    ProductRegistrationManager productRegistrationManager = new ProductRegistrationManager(new EfProductRegistrationDAL());
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.WriteLine(Messages.LoadingList);

                    foreach (var item in productRegistrationManager.GetAll().Data)
                    {
                        Console.WriteLine(item.NewProductId.ToString() + ")" + " PRODUCT NAME : " + item.NewProductName + " | PRODUCT PRICE : " + item.NewProductPrice + " | PRODUCT QUANTITY: " + item.NewProductQuantity + " | PRODUCT IMAGE: " + item.NewProductImage);

                    }
                    Console.WriteLine(Messages.Listing);
                }
                else if (seccontex == "5")
                {
                    Context();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    Console.WriteLine(Messages.Error + "\n\n\n");

                }

            }
            if (sec == "5")
            {
                string seccontex;
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.Clear();

                Console.WriteLine(" 1) ADD ");
                Console.WriteLine(" 2) DELETE ");
                Console.WriteLine(" 3) UPDATE ");
                Console.WriteLine(" 4) LIST ");
                Console.WriteLine(" 5) GO HOME BACK ");
                seccontex = Console.ReadLine();
                if (seccontex == "1")
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Clear();
                    string buyername, buyersurname, buyerproduct, buyerprice, buyerquantity, image;
                    Console.Write(" BUYER NAME :  ");
                    buyername = Console.ReadLine();
                    Console.Write(" BUYER SURNAME :  ");
                    buyersurname = Console.ReadLine();
                    Console.Write(" BUYER PROJECT : ");
                    buyerproduct = Console.ReadLine();
                    Console.Write(" BUYER PRICE : ");
                    buyerprice = Console.ReadLine();
                    Console.Write(" BUYER QUANTITY: ");
                    buyerquantity = Console.ReadLine();
                    Console.Write(" BUYER IMAGE: ");
                    image = Console.ReadLine();

                    Console.Clear();
                    Console.WriteLine(Messages.LoadingList);
                    SoldProductManager soldProductManager = new SoldProductManager(new EfSoldProductDAL());
                    soldProductManager.Add(new SoldProduct
                    {
                        BuyerName = buyername,
                        BuyerSurname = buyersurname,
                        BuyerProject = buyerproduct,
                        BuyerPrice = Convert.ToInt32(buyerprice.ToString()),
                        BuyerQuantity = Convert.ToInt32(buyerquantity.ToString()),
                        BuyerImage = image
                    });
                }
                else if (seccontex == "2")
                {
                    SoldProductManager soldProductManager = new SoldProductManager(new EfSoldProductDAL());
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.Clear();
                    foreach (var item in soldProductManager.GetAll().Data)
                    {
                        Console.WriteLine(item.BuyerId + ")" + item.BuyerName + " " + item.BuyerSurname + " " + item.BuyerProject);
                    };
                    string buyerid;
                    Console.Write(" BUYER ID : ");
                    buyerid = Console.ReadLine();
                    soldProductManager.Delete(new SoldProduct
                    {
                        BuyerId = Convert.ToInt32(buyerid.ToString())
                    });
                    Console.WriteLine(Messages.Succes);
                }
                else if (seccontex == "3")
                {
                    SoldProductManager soldProductManager = new SoldProductManager(new EfSoldProductDAL());
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Clear();
                    foreach (var item in soldProductManager.GetAll().Data)
                    {
                        Console.WriteLine(item.BuyerId.ToString() + ")" + item.BuyerName + " " + item.BuyerSurname + " " + item.BuyerProject + "\n");

                    }
                    string buyername, buyersurname, buyerproduct, buyerprice, buyerquantity, image, buyerid;
                    Console.Write(" BUYER ID:");
                    buyerid = Console.ReadLine();
                    Console.Write(" BUYER NAME :  ");
                    buyername = Console.ReadLine();
                    Console.Write(" BUYER SURNAME :  ");
                    buyersurname = Console.ReadLine();
                    Console.Write(" BUYER PRODUCT : ");
                    buyerproduct = Console.ReadLine();
                    Console.Write(" BUYER PRICE : ");
                    buyerprice = Console.ReadLine();
                    Console.Write(" BUYER QUANTITY: ");
                    buyerquantity = Console.ReadLine();
                    Console.Write(" BUYER IMAGE: ");
                    image = Console.ReadLine();
                    soldProductManager.Update(new SoldProduct { BuyerId = Convert.ToInt32(buyerid.ToString()), BuyerName = buyername, BuyerSurname = buyersurname, BuyerProject = buyerproduct, BuyerPrice = Convert.ToInt32(buyerprice.ToString()), BuyerQuantity = Convert.ToInt32(buyerquantity.ToString()), BuyerImage = image });
                    Console.WriteLine(Messages.Succes);
                }
                else if (seccontex == "4")
                {
                    SoldProductManager soldProductManager = new SoldProductManager(new EfSoldProductDAL());
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Clear();
                    Console.WriteLine(Messages.LoadingList);

                    foreach (var item in soldProductManager.GetAll().Data)
                    {
                        Console.WriteLine(item.BuyerId.ToString() + ")" + " BUYER NAME : " + item.BuyerName + " | BUYER SURNAME : " + item.BuyerSurname + " | BUYER PROJECT: " + item.BuyerProject + " | BUYER PRICE: " + item.BuyerPrice + " | BUYER QUANTITY: " + item.BuyerQuantity + " | BUYER IMAGE: " + item.BuyerImage);

                    }
                    Console.WriteLine(Messages.Listing);
                }
                else if (seccontex == "5")
                {
                    Context();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    Console.WriteLine(Messages.Error + "\n\n\n");

                }
            }
            if (sec == "6")
            {
                string seccontex;
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.Clear();

                Console.WriteLine(" 1) ADD ");
                Console.WriteLine(" 2) DELETE ");
                Console.WriteLine(" 3) UPDATE ");
                Console.WriteLine(" 4) LIST ");
                Console.WriteLine(" 5) GO HOME BACK ");
                seccontex = Console.ReadLine();


                if (seccontex == "1")
                {
                    string Name;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Clear();
                    Console.Write(" Description:  ");
                    Name = Console.ReadLine();


                    Console.Clear();
                    Console.WriteLine(Messages.LoadingList);

                    RegionManager regionManager = new RegionManager(new EfRegionDAL());
                    regionManager.Add(new Region
                    {
                        RegionDescription = Name

                    });
                    Console.WriteLine(Messages.Succes);
                }

                else if (seccontex == "2")
                {
                    RegionManager regionManager = new RegionManager(new EfRegionDAL());
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.Clear();
                    foreach (var item in regionManager.GetAll().Data)
                    {
                        Console.WriteLine(item.RegionId.ToString() + ")" + item.RegionDescription + "\n");
                    }
                    string RegionId;

                    Console.Write(" RegionId : ");
                    RegionId = Console.ReadLine();


                    regionManager.Delete(new Region { RegionId = Convert.ToInt32(RegionId.ToString()) });
                    Console.WriteLine(Messages.Succes);

                }

                else if (seccontex == "3")
                {
                    RegionManager regionManager = new RegionManager(new EfRegionDAL());
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.Clear();
                    foreach (var item in regionManager.GetAll().Data)
                    {
                        Console.WriteLine(item.RegionId.ToString() + ")" + item.RegionDescription + "\n");
                    }
                    string Name, id;

                    Console.Write(" RegionId:  ");
                    id = Console.ReadLine();
                    Console.Write(" Description ");
                    Name = Console.ReadLine();



                    regionManager.Update(new Region
                    {
                        RegionId = Convert.ToInt32(id.ToString()),
                        RegionDescription = Name
                    });
                    Console.WriteLine(Messages.Succes);

                }

                else if (seccontex == "4")
                {
                    RegionManager regionManager = new RegionManager(new EfRegionDAL());
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.Clear();
                    Console.WriteLine(Messages.LoadingList);
                    foreach (var item in regionManager.GetAll().Data)

                    {
                        Console.WriteLine(item.RegionId.ToString() + ")" + " | Description: " + item.RegionDescription);

                    }
                    Console.WriteLine(Messages.Listing);

                }

                else if (seccontex == "5")
                {
                    Context();

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    Console.WriteLine(Messages.Error + "\n\n\n");
                }
            }


        }

        private static void GetProductDetails()
        {
            ProductRegistrationManager manager = new ProductRegistrationManager(new EfProductRegistrationDAL());
            foreach (var item in manager.GetProductDetails().Data)
            {
                Console.WriteLine(item.BuyerName + "/" + item.ProductName);
            }
        }

        static void Main(string[] args)
        {

            //GetProductDetails();
            Context();


        }
    }
}

