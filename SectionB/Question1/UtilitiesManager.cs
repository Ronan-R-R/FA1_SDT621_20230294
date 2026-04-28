using System;
using System.Collections.Generic;
using System.Linq;

namespace Question1
{
    public class UtilitiesManager
    {
        // Urgency Score = PriorityLevel * SeverityLevel
        public int CalculateUrgencyScore(ServiceRequest request)
        {
            return request.PriorityLevel * request.SeverityLevel;
        }

        // Adjusted resolution: EstimatedResolutionHours + (UrgencyScore / 10), rounded up
        public int CalculateAdjustedResolution(ServiceRequest request)
        {
            int urgency = CalculateUrgencyScore(request);
            return (int)Math.Ceiling(request.EstimatedResolutionHours + (urgency / 10.0));
        }

        // Household Impact Score = UrgencyScore * MonthlyUtilityUsage / 100
        public double CalculateHouseholdImpactScore(ServiceRequest request)
        {
            int urgency = CalculateUrgencyScore(request);
            return Math.Round(urgency * request.Resident.MonthlyUtilityUsage / 100.0, 2);
        }

        public void GenerateReport(ServiceRequest request)
        {
            int urgency = CalculateUrgencyScore(request);
            int adjusted = CalculateAdjustedResolution(request);
            double impact = CalculateHouseholdImpactScore(request);

            Console.WriteLine("\n==== Service Report ====");
            Console.WriteLine($"Resident: {request.Resident.Name}");
            Console.WriteLine($"Service Type: {request.RequestType}");
            Console.WriteLine($"Urgency Score: {urgency}");
            Console.WriteLine($"Adjusted Resolution: {adjusted} hours");
            Console.WriteLine($"Household Impact Score: {impact:F2}");
        }

        public void GenerateFinalSummary(List<ServiceRequest> processed)
        {
            if (processed.Count == 0)
            {
                Console.WriteLine("\nNo requests were processed.");
                return;
            }

            ServiceRequest highest = processed.OrderByDescending(r => CalculateUrgencyScore(r)).First();

            Console.WriteLine("\n==== FINAL MUNICIPAL SUMMARY ====");
            Console.WriteLine("Highest priority issue:");
            Console.WriteLine($"Resident: {highest.Resident.Name}");
            Console.WriteLine($"Service Type: {highest.RequestType}");
            Console.WriteLine($"Urgency Score: {CalculateUrgencyScore(highest)}");
            Console.WriteLine($"Adjusted Resolution: {CalculateAdjustedResolution(highest)} hours");
            Console.WriteLine($"Household Impact Score: {CalculateHouseholdImpactScore(highest):F2}");
        }
    }
}