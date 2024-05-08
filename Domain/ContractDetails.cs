namespace too_many_params.Domain
{
    public class ContractDetails
    {
        public ContractDetails()
        {
        }

        public ContractDetails(string contractNumber, string clientName, DateTime startDate, DateTime endDate, decimal amount, string description)
        {
            ContractNumber = contractNumber;
            ClientName = clientName;
            StartDate = startDate;
            EndDate = endDate;
            Amount = amount;
            Description = description;
        }

        public string ContractNumber { get; private set; }
        public string ClientName { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public decimal Amount { get; private set; }
        public string Description { get; private set; }
    }
}