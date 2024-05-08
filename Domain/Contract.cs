namespace too_many_params.Domain
{
    public class Contract
    {
        public Contract()
        {
        }
        public Contract(int? id, ContractDetails details, ContractStatus status)
        {
            Id = id;
            Details = details;
            Status = status;
        }

        public int? Id { get; private set; }
        public ContractDetails Details { get; private set; }
        public ContractStatus Status { get; private set; }
    }
}
