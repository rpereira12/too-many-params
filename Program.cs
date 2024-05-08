using Microsoft.EntityFrameworkCore;
using too_many_params.Domain;
using too_many_params.Infra;

class Program
{
    static void Main(string[] args)
    {
        using (var context = new ParamsDbContext())
        {
            // Create
            var newContract = new Contract(
                null,
                new ContractDetails(
                    "CON123",
                    "Client A",
                    DateTime.Now,
                    DateTime.Now.AddDays(365),
                    1000,
                    "Sample contract"
                ),
                new ContractStatus(true, true, true, false)
            );

            context.Contracts.Add(newContract);
            context.SaveChanges();
            Console.WriteLine("New contract added.");

            // Read
            var contracts = context.Contracts
                .Include(c => c.Details)
                .Include(c => c.Status)
                .ToList();

            Console.WriteLine("\nContracts:");
            foreach (var contract in contracts)
            {
                Console.WriteLine($"Contract Number: {contract.Details.ContractNumber}, " +
                                  $"Client: {contract.Details.ClientName}, " +
                                  $"Start Date: {contract.Details.StartDate}, " +
                                  $"Amount: {contract.Details.Amount}, " +
                                  $"Is Active: {contract.Status.IsActive}");
            }
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}