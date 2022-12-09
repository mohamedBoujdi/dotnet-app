//Tester l'application
namespace FIRSTAPP;

using Entity;
using Service;
    
    class Test
    {
        static void Main(string[] args)
        {

            AccountService accountService = new AccountServiceImpl();
            Account account1 = new Account(1, "John", 1000, "ggjjh@gmail.com", "123456", "0666666666", "Paris", "user", "active");
            Account account2 = new Account(2, "Jane", 2000, "djdgjfk@gmail.com" ,"534345", "0677777777", "Agadir", "Admin", "active");
        accountService.AddNewAccount(account1);
        accountService.AddNewAccount(account2);
        Console.WriteLine("Liste des comptes");
        List<Account> accounts = accountService.GetAllAccounts();
        foreach (Account account in accounts)
        {
            Console.WriteLine(account);
        }
        Console.WriteLine("Liste des comptes crédités");
        List<Account> creditedAccounts = accountService.GetCreditedAccounts();
        foreach (Account account in creditedAccounts)
        {
            Console.WriteLine(account);
        }
        Console.WriteLine("Liste des comptes débités");
        List<Account> debitedAccounts = accountService.GetDebitedAccounts();
        foreach (Account account in debitedAccounts)
        {
            Console.WriteLine(account);
        }
        Console.WriteLine("Moyenne des soldes");
        double balanceAVG = accountService.GetBalanceAVG();
        Console.WriteLine(balanceAVG);
        Console.WriteLine("Compte par id");
        Account accountById = accountService.GetAccountById(1);
        Console.WriteLine(accountById);
        }

    }
