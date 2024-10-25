namespace iwilltry
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Product product = new Product (2,"milk",3);

            string operation;
            bool f = false;

            double productNo;
            string productName;
            double productPrice;

            do
            {
                Console.WriteLine("1.mehsul elave et 2.filter et(name) 3.filter et(type) 0.Exit");
                operation = Console.ReadLine();
                switch (operation)
                {

                    case "1":
                        
                            bool isNo = false;
                            do
                            {
                                Console.WriteLine("mehsul nomresi daxil et");
                                isNo = double.TryParse(Console.ReadLine(), out productNo);
                                Console.WriteLine("mehsul adi daxil et");
                                productName = Console.ReadLine();

                                bool isPrice = false;
                                do
                                {
                                    Console.WriteLine("mehsul qiymeti daxil et");
                                    isPrice = double.TryParse(Console.ReadLine(), out productPrice);


                                } while (true);

                                break;



                            } while (true);
                            break;

                        



                        case "2":
                        


                        
                        break;

                      
                        
                        case "3":
                        

                        
                        break;


                       

                        case "0":
                        
                            f = true;
                            Console.WriteLine("proqramdan cixis et");
                        
                        break;

                       
                        default:
                        break;
                }
            }
            while (!f);


            
            
        
        
        
        
        
        
        
        }
    }
}
