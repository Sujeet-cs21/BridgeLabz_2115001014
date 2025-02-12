using System;

namespace PP_11_02_25
{
    class Process
    {
        public int ProcessID;
        public int BurstTime;
        public int Priority;
        public Process Next;

        public Process(int processID, int burstTime, int priority)
        {
            ProcessID = processID;
            BurstTime = burstTime;
            Priority = priority;
        }
    }

    class Class6
    {
        public Process head;

        public void AddProcessAtBegining(int processID, int burstTime, int priority)
        {
            Process newProcess=new Process(processID, burstTime, priority);

            if(head == null)
            {
                head = newProcess;
                newProcess.Next=head;
            }
            else
            {
                Process temp=head;

                while (temp.Next != head)
                    temp = temp.Next;

                temp.Next = newProcess;
                newProcess.Next = head;
                head = newProcess;
            }
        }

        public void AddProcessInEnd(int processID, int burstTime, int priority)
        {
            Process newProcess = new Process(processID, burstTime, priority);

            if (head == null)
            {
                head = newProcess;
                newProcess.Next = head;

                return;
            }
            Process temp = head;

            while (temp.Next != head)
                temp = temp.Next;

            temp.Next = newProcess;
            newProcess.Next = head;
        }

        public void RemoveProcess(int processID)
        {
            if (head == null)
            {
                Console.WriteLine("No Process Available");
                return;
            }

            // Single node case
            if (head.Next == head && head.ProcessID == processID)
            {
                head = null;
                return;
            }

            // If the head itself holds the processID
            if (head.ProcessID == processID)
            {
                // Find the last node to update its Next pointer
                Process tail = head;
                while (tail.Next != head)
                {
                    tail = tail.Next;
                }

                tail.Next = head.Next;
                head = head.Next;
                return;
            }

            //Searching for the node to delete
            Process temp = head;
            while (temp.Next != head)
            {
                if (temp.Next.ProcessID == processID)
                {
                    temp.Next = temp.Next.Next;
                    return;
                }
                temp = temp.Next;
            }
            Console.WriteLine("Process not found.");
        }

        public void RoundRobinScheduling(int timeQuantum)
        {
            if (head == null) return;

            int totalWaitingTime = 0, totalTurnaroundTime = 0, processCount = 0;
            Process current = head;

            while (head != null)
            {
                if (current.BurstTime > timeQuantum)
                {
                    current.BurstTime -= timeQuantum;
                    Console.WriteLine("Process " + current.ProcessID + " executed for " + timeQuantum + " sec.");
                    current = current.Next;
                }
                else
                {
                    Console.WriteLine("Process " + current.ProcessID + " completed execution.");
                    totalTurnaroundTime += current.BurstTime;
                    RemoveProcess(current.ProcessID);
                    current = head;
                }
            }

            Console.WriteLine("Average Turnaround Time: " + (double)totalTurnaroundTime / processCount);
        }

        public void DisplayProcess()
        {
            if (head == null)
            {
                Console.WriteLine("No process available");
            }
            Process temp = head;
            while (temp.Next != head)
            {
                Console.Write($"{temp.ProcessID}->");
                temp = temp.Next;
            }
            Console.WriteLine($"{temp.ProcessID}");
        }

        public static void Main6()
        {
            Class6 scheduler = new Class6();

            scheduler.AddProcessAtBegining(2, 10, 1);
            scheduler.AddProcessAtBegining(1, 5, 2);
            scheduler.AddProcessInEnd(3, 4, 1);
            scheduler.AddProcessInEnd(4, 7, 3);
            scheduler.DisplayProcess();
            scheduler.RoundRobinScheduling(3);
            scheduler.RoundRobinScheduling(4);
        }
    }
}
