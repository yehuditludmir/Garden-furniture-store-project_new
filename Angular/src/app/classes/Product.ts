export class Product{
    // public string Id { get; set; }

    // public string Name { get; set; }
    // public string CategoryId { get; set; }
    // public string CompanyId { get; set; }

    // public string Description { get; set; }

    // public int Price { get; set; }
    // public int Amount { get; set; }

    // public DateTime LastUpdate { get; set; }

    // public string CategoryName { get; set; }

    // public string CompanyName { get; set; }

    constructor(public Id:number,public Name:string, public CategoryId:number,
      public CompanyId:number, public Price:number,
      public Amount:number, public Picture:string, public LastUpdate:Date, public CategoryName:string,
      public CompanyName:string,public Description?:string 
    ){}


}