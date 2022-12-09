//Créer l'interface AccountService

//import entity/Account.cs
using FIRSTAPP.Entity;

namespace FIRSTAPP.Service;


    public interface AccountService
    {
        public Account AddNewAccount(Account account);
        public Account GetAccountById(int id);
        public List<Account> GetAllAccounts();
        public List<Account> GetDebitedAccounts();
        public List<Account> GetCreditedAccounts();
        public double GetBalanceAVG();
        
    }

