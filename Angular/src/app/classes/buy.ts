export class buy{
    constructor(public Id:number,public DateOfBuy:Date,public AmountPay:number,
        public  IsPay:boolean,public UserId:number,public UserName:string,public Remark?:string
    ){}
}