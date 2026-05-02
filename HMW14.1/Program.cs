var products = new List<Product>()
{                                                                                                                                                                    
    new Carrot(15),                                             
    new Potato(20, 4),
    new Cucumber(14, 2)
};  

VegetableShop shop = new VegetableShop();
shop.AddProducts(products);                                                                                                                                                                                                            
shop.PrintProductsInfo();

public abstract class Product
{                                                                                                                                                                    
    protected decimal BasePrice { get; }                        
                                                                                                                                                                       
    protected Product(decimal basePrice)
    {                                                                                                                                                                
        BasePrice = basePrice;                                  
    }

    public abstract decimal Price { get; }                                                                                                                           
   
    public abstract void PrintInfo();                                                                                                                                
}

public class Carrot : Product                                   
{                                                                                                                                                                    
    public Carrot(decimal basePrice) : base(basePrice) { }      
                                                                                                                                                                       
    public override decimal Price => BasePrice;
                                                                                                                                                                       
    public override void PrintInfo()                            
    {
        Console.WriteLine($"Product: Carrot, Price: {Price}");
    }                                                                                                                                                                
}
                                                                                                                                                                       
public class Tomato : Product                                   
{
    public Tomato(decimal basePrice) : base(basePrice) { }

    public override decimal Price => BasePrice;

    public override void PrintInfo()                                                                                                                                 
    {
        Console.WriteLine($"Product: Tomato, Price: {Price}");                                                                                                       
    }                                                           
}

  public class Potato : Product                                   
  {                                                                                                                                                                    
      private int Count { get; }                                  

      public Potato(decimal basePrice, int count) : base(basePrice)
      {
          Count = count;
      }                                                                                                                                                                
   
      public override decimal Price => BasePrice * Count;                                                                                                              
                                                                  
      public override void PrintInfo()
      {
          Console.WriteLine($"Product: Potato, Price: {BasePrice}, Count: {Count}, Total price: {Price}");
      }                                                                                                                                                                
  }
                                                                                                                                                                       
  public class Cucumber : Product                                 
  {
      private int Count { get; }

      public Cucumber(decimal basePrice, int count) : base(basePrice)                                                                                                  
      {
          Count = count;                                                                                                                                               
      }                                                           

      public override decimal Price => BasePrice * Count;

      public override void PrintInfo()
      {
          Console.WriteLine($"Product: Cucumber, Price: {BasePrice}, Count: {Count}, Total price: {Price}");
      }                                                                                                                                                                
  }

  public class VegetableShop                                                                                                                                           
  {                                                               
      private List<Product> _products = new List<Product>();

      public void AddProducts(IEnumerable<Product> products)                                                                                                           
      {
          _products.AddRange(products);                                                                                                                                
      }                                                           

      public void PrintProductsInfo()
      {
          foreach (var product in _products)
          {
              product.PrintInfo();                                                                                                                                     
          }
                                                                                                                                                                       
          decimal total = _products.Sum(p => p.Price);            
          Console.WriteLine($"Total products price: {total}");
      }                                                                                                                                                                
  }

    