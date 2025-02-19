using System;
using System.Collections.Generic;

namespace PP_19_02_25
{
    class VotingSystem
    {
        private Dictionary<string, int> votes = new Dictionary<string, int>();
        private SortedDictionary<string, int> sortedVotes = new SortedDictionary<string, int>();
        private LinkedList<string> voteOrder = new LinkedList<string>();

        public void CastVote(string candidate)
        {
            if (votes.ContainsKey(candidate))
            {
                votes[candidate]++;
                sortedVotes[candidate]++;
            }
            else
            {
                votes[candidate] = 1;
                sortedVotes[candidate] = 1;
                voteOrder.AddLast(candidate);
            }
        }

        public void DisplayResults()
        {
            Console.WriteLine("Vote Results (Sorted by Name):");
            foreach (var vote in sortedVotes)
            {
                Console.WriteLine($"{vote.Key}: {vote.Value} votes");
            }
        }

        public void DisplayVoteOrder()
        {
            Console.WriteLine("Vote Order:");
            foreach (var candidate in voteOrder)
            {
                Console.WriteLine(candidate);
            }
        }

        public static void Main2()
        {
            VotingSystem votingSystem = new VotingSystem();

            votingSystem.CastVote("Voter1");
            votingSystem.CastVote("Voter2");
            votingSystem.CastVote("Voter1");
            votingSystem.CastVote("Voter3");
            votingSystem.CastVote("Voter2");
            votingSystem.CastVote("Voter1");

            votingSystem.DisplayResults();
            Console.WriteLine();
            votingSystem.DisplayVoteOrder();
        }
    }

}
