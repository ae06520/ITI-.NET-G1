using System;
class Banking
{
    private int id;
    private string name;
    private float balance;
    public Banking()
    {
        id = 0;
        balance = 0f;
        name = "";
    }
    public Banking(int id,float balance,string name)
    {
        this.id = id;
        this.balance = balance;
        this.name =name;
    }
    public void setid(int id)
    {
        this.id = id;
    }
    public void setname(string name )
    {
        this.name = name;
    }
    public void setbalance(float balance)
    {
        this.balance = balance;
    }
    public int getId() 
    {
        return id;
    } 
    public float getBalance() 
    { 
        return balance; 
    } 
    public string  getName() 
    {
        return name;
    } 
    public void Deposite(float amount)
    {
        balance += amount;
        Console.WriteLine("The current acount balance is balance \n", balance);
    }
    public void Withdarw(float amount)
    {
        balance -= amount;
        Console.WriteLine("The current acount balance is balance \n", balance);
    }
    public void Display()
    {
        Console.WriteLine("**************************************************************");
        Console.WriteLine("Your account Data is:");
        Console.WriteLine("**************************************************************");
        Console.WriteLine("Name : name", name);
        Console.WriteLine("Id: id",id);
        Console.WriteLine("Balance : balance", balance);
        Console.WriteLine("**************************************************************");


    }

}
class Task2
{

}