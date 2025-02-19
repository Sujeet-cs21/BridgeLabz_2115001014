using System;
using System.Collections.Generic;
using System.Linq;

namespace PP_19_02_25
{
    class Policy
    {
        public string PolicyNumber { get; set; }
        public string CoverageType { get; set; }
        public DateTime ExpiryDate { get; set; }

        public override bool Equals(object obj)
        {
            return obj is Policy policy && PolicyNumber == policy.PolicyNumber;
        }

        public override int GetHashCode()
        {
            return PolicyNumber.GetHashCode();
        }
    }

    class InsurancePolicyManagement
    {
        public static void Main1()
        {
            HashSet<Policy> uniquePolicies = new HashSet<Policy>();
            LinkedList<Policy> orderedPolicies = new LinkedList<Policy>();
            SortedSet<Policy> sortedPolicies = new SortedSet<Policy>(Comparer<Policy>.Create((a, b) => a.ExpiryDate.CompareTo(b.ExpiryDate)));

            // Adding example policies
            AddPolicy(uniquePolicies, orderedPolicies, sortedPolicies, new Policy { PolicyNumber = "P001", CoverageType = "Health", ExpiryDate = DateTime.Now.AddDays(10) });
            AddPolicy(uniquePolicies, orderedPolicies, sortedPolicies, new Policy { PolicyNumber = "P002", CoverageType = "Auto", ExpiryDate = DateTime.Now.AddDays(40) });
            AddPolicy(uniquePolicies, orderedPolicies, sortedPolicies, new Policy { PolicyNumber = "P003", CoverageType = "Home", ExpiryDate = DateTime.Now.AddDays(20) });

            Console.WriteLine("All Unique Policies:");
            foreach (var policy in uniquePolicies)
            {
                Console.WriteLine($"{policy.PolicyNumber} - {policy.CoverageType} - {policy.ExpiryDate}");
            }

            Console.WriteLine("\nPolicies Expiring Soon:");
            foreach (var policy in sortedPolicies.Where(p => (p.ExpiryDate - DateTime.Now).TotalDays <= 30))
            {
                Console.WriteLine($"{policy.PolicyNumber} - {policy.CoverageType} - {policy.ExpiryDate}");
            }
        }

        static void AddPolicy(HashSet<Policy> uniquePolicies, LinkedList<Policy> orderedPolicies, SortedSet<Policy> sortedPolicies, Policy policy)
        {
            if (uniquePolicies.Add(policy))
            {
                orderedPolicies.AddLast(policy);
                sortedPolicies.Add(policy);
            }
        }
    }
}
