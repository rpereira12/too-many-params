namespace too_many_params.Domain.BrokenContract
{
    public class BrokenContract
    {
        public BrokenContract(
            int? id,
            string contractNumber,
            string clientName,
            DateTime startDate,
            DateTime endDate,
            decimal amount,
            string description,
            bool isActive,
            bool isApproved,
            bool isSigned,
            bool isCancelled)
        {
            Id = id;
            ContractNumber = contractNumber;
            ClientName = clientName;
            StartDate = startDate;
            EndDate = endDate;
            Amount = amount;
            Description = description;
            IsActive = isActive;
            IsApproved = isApproved;
            IsSigned = isSigned;
            IsCancelled = isCancelled;
        }

        public int? Id { get; private set; }
        public string ContractNumber { get; private set; }
        public string ClientName { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public decimal Amount { get; private set; }
        public string Description { get; private set; }
        public bool IsActive { get; private set; }
        public bool IsApproved { get; private set; }
        public bool IsSigned { get; private set; }
        public bool IsCancelled { get; private set; }
    }

}
