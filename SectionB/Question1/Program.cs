using System;
using System.Collections.Generic;

namespace Question1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Welcome to Emfuleni Municipality Service Desk ===");

            UtilitiesManager manager = new UtilitiesManager();
            List<Resident> residents = new List<Resident>();
            List<ServiceRequest> serviceRequests = new List<ServiceRequest>();
            List<ServiceRequest> processedRequests = new List<ServiceRequest>();

            // ── Step 1: Register residents ──────────────────────────────────────
            Console.Write("How many residents do you want to register? ");
            int residentCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < residentCount; i++)
            {
                Console.WriteLine($"\n--- Resident {i + 1} ---");

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Address: ");
                string address = Console.ReadLine();

                Console.Write("Account Number: ");
                string accountNumber = Console.ReadLine();

                Console.Write("Monthly Utility Usage (kWh or litres): ");
                double usage = double.Parse(Console.ReadLine());

                residents.Add(new Resident(name, address, accountNumber, usage));
            }

            // ── Step 2: Log service requests ────────────────────────────────────
            Console.Write("\nHow many service requests do you want to log? ");
            int requestCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < requestCount; i++)
            {
                Console.WriteLine($"\n--- Service Request {i + 1} ---");

                // Select resident
                Console.Write($"Select resident by number (1 to {residents.Count}): ");
                int residentIndex = int.Parse(Console.ReadLine()) - 1;
                Resident selectedResident = residents[residentIndex];

                Console.Write("Request Type (e.g., Water Outage, Burst Pipe): ");
                string requestType = Console.ReadLine();

                Console.Write("Priority Level (1-5): ");
                int priority = int.Parse(Console.ReadLine());

                Console.Write("Severity Level (1-10): ");
                int severity = int.Parse(Console.ReadLine());

                Console.Write("Estimated Resolution Hours: ");
                int hours = int.Parse(Console.ReadLine());

                serviceRequests.Add(new ServiceRequest(selectedResident, requestType, priority, severity, hours));
            }

            // ── Step 3: Display pending queue with urgency scores ────────────────
            Console.WriteLine("\n==== Pending Service Request Queue ====");
            for (int i = 0; i < serviceRequests.Count; i++)
            {
                ServiceRequest req = serviceRequests[i];
                int urgency = manager.CalculateUrgencyScore(req);
                Console.WriteLine($"{i + 1}. {req.Resident.Name} | {req.RequestType} | Priority: {req.PriorityLevel} | Severity: {req.SeverityLevel} | Urgency Score: {urgency}");
            }

            // ── Step 4: Interactively process requests ───────────────────────────
            bool processing = true;
            while (processing)
            {
                // Build list of unprocessed
                List<int> pending = new List<int>();
                for (int i = 0; i < serviceRequests.Count; i++)
                    if (!serviceRequests[i].IsProcessed)
                        pending.Add(i);

                if (pending.Count == 0)
                {
                    Console.WriteLine("\nAll service requests have been processed.");
                    break;
                }

                Console.WriteLine("\n==== Pending Requests ====");
                foreach (int idx in pending)
                {
                    ServiceRequest req = serviceRequests[idx];
                    Console.WriteLine($"{idx + 1}. {req.Resident.Name} | {req.RequestType} | Urgency Score: {manager.CalculateUrgencyScore(req)}");
                }

                Console.Write($"Select a request to process (1-{serviceRequests.Count}) or 0 to stop: ");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 0)
                {
                    processing = false;
                }
                else if (choice >= 1 && choice <= serviceRequests.Count)
                {
                    ServiceRequest selected = serviceRequests[choice - 1];

                    if (selected.IsProcessed)
                    {
                        Console.WriteLine("That request has already been processed. Please choose another.");
                    }
                    else
                    {
                        selected.IsProcessed = true;
                        processedRequests.Add(selected);
                        manager.GenerateReport(selected);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid selection. Please try again.");
                }
            }

            // ── Step 5: Final summary ────────────────────────────────────────────
            manager.GenerateFinalSummary(processedRequests);

            Console.WriteLine("\nThank you for using the Emfuleni Municipality Service Desk.");
        }
    }
}