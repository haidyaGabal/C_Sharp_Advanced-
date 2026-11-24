using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Advanced.Reflection
{


    public class BaseEntity
    {
        // Properties
        public Guid Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int CurrentState { get; set; }
        public bool IsDeleted { get; set; }
        public decimal Balance { get; set; }

        // Private field
        private string _internalCode = "SYS-001";

        // Protected property
        protected string InternalName { get; set; }

        // Read-only property
        public string EntityType => GetType().Name;

        // Static property
        public static int TotalEntities { get; private set; }

        // Constructor
        public BaseEntity()
        {
            Id = Guid.NewGuid();
            CreatedDate = DateTime.Now;
            CurrentState = 1;
            TotalEntities++;
        }

        // Parameterized constructor
        public BaseEntity(string createdBy, int currentState)
        {
            Id = Guid.NewGuid();
            CreatedBy = createdBy;
            CreatedDate = DateTime.Now;
            CurrentState = currentState;
            TotalEntities++;
        }

        // Public methods
        public void Activate()
        {
            CurrentState = 1;
        }

        public void Deactivate()
        {
            CurrentState = 0;
        }

        public void UpdateDate()
        {
            UpdatedDate = DateTime.Now;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Created By: {CreatedBy}");
            Console.WriteLine($"Created Date: {CreatedDate}");
            Console.WriteLine($"Current State: {CurrentState}");
        }

        // Method with parameters and return value
        public bool IsActive()
        {
            return CurrentState == 1;
        }

        public decimal CalculateBalance(decimal amount, bool add)
        {
            return add ? Balance + amount : Balance - amount;
        }

        // Protected method
        protected void SetInternalCode(string code)
        {
            _internalCode = code;
        }

        // Private method
        private void LogChanges()
        {
            Console.WriteLine("Changes logged.");
        }

        // Static method
        public static string GetEntityDescription()
        {
            return "Base entity for application models.";
        }

        // Method with optional parameter
        public void ChangeStatus(int status = 1, string? reason = null)
        {
            CurrentState = status;
            Console.WriteLine($"Status changed. Reason: {reason}");
        }
    }
}
