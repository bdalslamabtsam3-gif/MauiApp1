  using MauiApp1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MauiApp1.Interfaces
{
    public interface IExpenseService
    {
        Expense GetExpenseById(Guid id); 
        void UpdateExpense(Expense expense); 
        List<Expense> GetAllExpenses();
        void AddExpense(Expense expense);
        void DeleteExpense(Guid id);
        decimal GetTotalExpenses();
    }
}
