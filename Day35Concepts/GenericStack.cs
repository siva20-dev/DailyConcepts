using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day35Concepts.GenericStackConcepts
{
    public class GenericStack
    {
        public void GerericStackExamples()
        {
            var stack = new Stack<string>();
            stack.Push("item1");
            stack.Push("item1");
            stack.Push("item1");

            var popedItem = stack.Pop();

            var peekedValue = stack.Peek();

            stack.Clear();
        }

        static ShoppingCart _shoppingCart;
        public void ShoppingCartExample()
        {
            int option = 0;

            _shoppingCart = new ShoppingCart();

            while (option != 5)
            {
                Console.WriteLine("\n\t\tMenu-select an Option");
                Console.WriteLine("\n\t\t---------------------");
                Console.WriteLine("\t\t1. Add an item to shopping cart");
                Console.WriteLine("\t\t2. Undo");
                Console.WriteLine("\t\t3. Redo");
                Console.WriteLine("\t\t4. View cart");
                Console.WriteLine("\t\t5. Exit");
                Console.WriteLine("Option: ");

                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        bool repeat = true;
                        while (repeat)
                        {
                            Console.Write("Enter item name(type 'n' to stop):");
                            var itemName = Console.ReadLine();

                            if (itemName != "n")
                                _shoppingCart.Add(itemName);

                            repeat = itemName == "n" ? false : true;
                        }

                        ShowCartItems();
                        break;
                    case 2:
                        _shoppingCart.Undo();
                        ShowCartItems();
                        break;

                    case 3:
                        _shoppingCart.Redo();
                        ShowCartItems();
                        break;

                    case 4:
                        ShowCartItems();
                        break;

                    case 5:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid Option !");
                        break;
                }
            }
        }

        public void ShowCartItems()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\tCart Items");
            Console.WriteLine("\t---------");
            _shoppingCart.ViewCart();
            Console.WriteLine("\t---------");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    public class ShoppingCart
    {
        Stack<string> cart = new Stack<string>();
        Stack<string> redoStack = new Stack<string>();

        public void Add(string itemName)
        {
            cart.Push(itemName);
        }

        public void Undo()
        {
            var item = cart.Pop();
            redoStack.Push(item);
        }

        public void Redo()
        {
            var item = redoStack.Pop();
            cart.Push(item);
        }

        public void ViewCart()
        {
            foreach (var item in cart)
            {
                Console.WriteLine("\t" + item);
            }
        }
    }
}
