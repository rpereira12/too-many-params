namespace too_many_params.Domain
{
    public class ContractStatus
    {
        public ContractStatus()
        {
        }
        public ContractStatus(bool isActive, bool isApproved, bool isSigned, bool isCancelled)
        {
            IsActive = isActive;
            IsApproved = isApproved;
            IsSigned = isSigned;
            IsCancelled = isCancelled;
        }

        public bool IsActive { get; private set; }
        public bool IsApproved { get; private set; }
        public bool IsSigned { get; private set; }
        public bool IsCancelled { get; private set; }
    }
}