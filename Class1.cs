using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab3_Task1
{
    /// <summary>
    /// Базовый класс печатного издания.
    /// </summary>

    public abstract class PrintEdition
    {
        /// <summary>
        /// Тип печатного издания.
        /// </summary>
        private string type = "Unknown";
        /// <summary>
        /// Имя печатного издания.
        /// </summary>
        protected string name = "Unknown";
        /// <summary>
        /// Цена печатного издания.
        /// </summary>
        protected int price = 0;
        /// <summary>
        /// Количество страниц печатного издания.
        /// </summary>
        protected int p_amount = 0;
        /// <summary>
        /// Признак наличия в продаже.
        /// </summary>
        protected bool isAvailable = false;
        /// <summary>
        /// Базовый конструктор.
        /// </summary>
        public PrintEdition() { }
        /// <summary>
        /// Конструктор с вводом типа печатного издания. 
        /// </summary>
        public PrintEdition(string type)
        {
            this.type = type;
        }
        /// <summary>
        /// Конструктор с вводом имени, цены и количества страниц печатного издания.
        /// </summary>
        public PrintEdition(string name, int price, int amount)
        {
            this.name = name;
            try
            {
                this.price = price;
                p_amount = amount;
            }
            catch (FormatException)
            {
                Console.WriteLine("Введено некорректное значение");
            }
            if (price < 0)
            {
                this.price = 0;
                Console.WriteLine("Цена не может быть меньше нуля");
            }
            else if (amount < 0)
            {
                p_amount = 0;
                Console.WriteLine("Количество страниц не может быть меньше нуля");
            }
        }
        /// <summary>
        /// Конструктор с вводом типа, имени, цены, количества страниц печатного издания. 
        /// </summary>
        public PrintEdition(string type, string name, int price, int amount)
        {
            this.type = type;
            this.name = name;
            try
            {
                this.price = price;
                p_amount = amount;
            }
            catch (FormatException)
            {
                Console.WriteLine("Введено некорректное значение");
            }
            if (price < 0)
            {
                this.price = 0;
                Console.WriteLine("Цена не может быть меньше нуля");
            }
            else if (amount < 0)
            {
                p_amount = 0;
                Console.WriteLine("Количество страниц не может быть меньше нуля");
            }
        }
        /// <summary>
        /// Конструктор с вводом типа, имени, цены, количества страниц печатного издания и признака наличия в продаже.
        /// </summary>
        public PrintEdition(string type, string name, int price, int amount, bool av)
        {
            this.type = type;
            this.name = name;
            try
            {
                this.price = price;
                p_amount = amount;
                isAvailable = av;
            }
            catch (FormatException)
            {
                Console.WriteLine("Введено некорректное значение");
            }
            if (price < 0)
            {
                this.price = 0;
                Console.WriteLine("Цена не может быть меньше нуля");
            }
            else if (amount < 0)
            {
                p_amount = 0;
                Console.WriteLine("Количество страниц не может быть меньше нуля");
            }

        }
        /// <summary>
        /// Свойство, характеризующее тип печатного издания. 
        /// </summary>
        public string Type
        {
            set
            {
                type = value;
            }
            get { return type; }
        }
        /// <summary>
        /// Свойство, характеризующее имя печатного издания. 
        /// </summary>
        public string Name
        {
            set
            {
                name = value;
            }
            get { return name; }
        }
        /// <summary>
        /// Свойство, характеризующее цену печатного издания. 
        /// </summary>
        public string Price
        {

            set
            {

                try
                {
                    price = int.Parse(value);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введено некорректное значение количества страниц");
                }
                if (price < 0)
                {
                    Console.WriteLine("Цена не может быть меньше нуля");
                    price = 0;
                }
            }
            get { return Convert.ToString(price); }
        }
        /// <summary>
        /// Свойство, характеризующее количество страниц печатного издания. 
        /// </summary>
        public string P_Amount
        {
            set
            {
                try
                {
                    p_amount = int.Parse(value);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введено некорректное значение количества страниц");
                }
                if (p_amount < 0)
                {
                    Console.WriteLine("Количество страниц не может быть меньше нуля");
                    p_amount = 0;
                }
            }
            get { return Convert.ToString(p_amount); }
        }
        /// <summary>
        /// Свойство, характеризующее признак наличия в продаже печатного издания.
        /// </summary>
        public string IsAvailable
        {
            set
            {
                try
                {
                    isAvailable = bool.Parse(value);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введено некорректное значение для признака наличия");
                }
            }
            get { return Convert.ToString(isAvailable); }
        }
        /// <summary>
        /// Метод, возвращающий информацию об экземпляре печатного издания в виде строки. 
        /// </summary>
        public virtual string Print()
        {
            string[] k = new string[] { type, name, Price, P_Amount, IsAvailable };
            string result = String.Join(" ", k);
            return result;
        }
    }
    /// <summary>
    /// Класс книги(производный от печатного издания). 
    /// </summary>
    public class Book : PrintEdition
    {
        /// <summary>
        /// Жанр книги. 
        /// </summary>
        private string genre = "Unknown";
        /// <summary>
        /// Базовый конструктор.
        /// </summary>
        public Book()
            : base("Book")
        { }
        /// <summary>
        /// Конструктор с вводом имени, цены и количества страниц книги.
        /// </summary>
        public Book(string name, int price, int p_amount)
            : base("Book", name, price, p_amount)
        { }
        /// <summary>
        /// Конструктор с вводом имени, жанра, цены и количества страниц книги.
        /// </summary>
        public Book(string name, string genre, int price, int p_amount)
            : base("Book", name, price, p_amount)
        {
            this.genre = genre;
        }
        /// <summary>
        /// Конструктор с вводом имени, жанра, цены, количества страниц и признак наличия книги в продаже.
        /// </summary>
        public Book(string name, string genre, int price, int p_amount, bool av)
            : base("Book", name, price, p_amount, av)
        {
            this.genre = genre;
        }
        /// <summary>
        /// Свойство, характеризующее жанр книги.
        /// </summary>
        public string Genre
        {
            set
            {
                genre = value;
            }
            get { return genre; }
        }
        /// <summary>
        /// Метод, возвращающий информацию об экземпляре книги в виде строки. 
        /// </summary>
        public override string Print()
        {
            string[] k = new string[] { name, genre, Price, P_Amount, IsAvailable };
            string result = String.Join(" ", k);
            return result;
        }
    }
    public class Magazine : PrintEdition
    {
        /// <summary>
        /// Читательский адрес журнала. То есть, тип/жанр журнала.
        /// </summary>
        private string read_adr = "Unknown";
        /// <summary>
        /// Базовый конструктор.
        /// </summary>
        public Magazine()
            : base("Magazine")
        { }
        /// <summary>
        /// Конструктор с вводом имени, цены и количества страниц журнала.
        /// </summary>
        public Magazine(string name, int price, int p_amount)
            : base("Magazine", name, price, p_amount)
        { }
        /// <summary>
        /// Конструктор с вводом имени, читательского адреса, цены и количества страниц журнала.
        /// </summary>
        public Magazine(string name, string adr, int price, int p_amount)
            : base("Magazine", name, price, p_amount)
        {
            read_adr = adr;
        }
        /// <summary>
        /// Конструктор с вводом имени, читательского адреса, цены, количества страниц и признак наличия журнала в продаже.
        /// </summary>
        public Magazine(string name, string adr, int price, int p_amount, bool av)
            : base("Magazine", name, price, p_amount, av)
        {
            read_adr = adr;
        }
        /// <summary>
        /// Свойство, характеризующее читательский адрес журнала.
        /// </summary>
        public string ReadAdress
        {
            set
            {
                read_adr = value;
            }
            get { return read_adr; }
        }
        /// <summary>
        /// Метод, возвращающий информацию об экземпляре журнала в виде строки. 
        /// </summary>
        public override string Print()
        {
            string[] k = new string[] { name, read_adr, Price, P_Amount, IsAvailable };
            string result = String.Join(" ", k);
            return result;
        }
    }
}