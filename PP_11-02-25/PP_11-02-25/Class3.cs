using System;

namespace PP_11_02_25
{
    class Task
    {
        public int TaskID;
        public string TaskName;
        public int Priority;
        public string DueDate;
        public Task Next;

        public Task(int taskID, string taskName, int priority, string dueDate)
        {
            TaskID = taskID;
            TaskName = taskName;
            Priority = priority;
            DueDate = dueDate;
        }
    }

    class Class3
    {
        private Task head;
        private Task current;

        public void AddTaskAtBeginning(int taskID, string taskName, int priority, string dueDate)
        {
            Task newTask = new Task(taskID, taskName, priority, dueDate);
            if (head == null)
            {
                head = newTask;
                head.Next = head;
                current = head;
            }
            else
            {
                Task temp = head;
                while (temp.Next != head)
                    temp = temp.Next;
                temp.Next = newTask;
                newTask.Next = head;
                head = newTask;
            }
        }

        public void AddTaskAtEnd(int taskID, string taskName, int priority, string dueDate)
        {
            Task newTask = new Task(taskID, taskName, priority, dueDate);
            if (head == null)
            {
                head = newTask;
                head.Next = head;
                current = head;
            }
            else
            {
                Task temp = head;
                while (temp.Next != head)
                    temp = temp.Next;
                temp.Next = newTask;
                newTask.Next = head;
            }
        }

        public void RemoveTask(int taskID)
        {
            if (head == null)
            {
                Console.WriteLine("No Tasks Available");
                return;
            }

            if (head.Next == head && head.TaskID == taskID)
            {
                head = null;
                return;
            }

            if (head.TaskID == taskID)
            {
                Task tail = head;
                while (tail.Next != head)
                {
                    tail = tail.Next;
                }

                tail.Next = head.Next;
                head = head.Next;
                return;
            }

            Task temp = head;
            while (temp.Next != head)
            {
                if (temp.Next.TaskID == taskID)
                {
                    temp.Next = temp.Next.Next;
                    return;
                }
                temp = temp.Next;
            }

            Console.WriteLine("Task not found.");
        }


        public void ViewCurrentTask()
        {
            if (current != null)
            {
                Console.WriteLine($"Current Task: {current.TaskID}, {current.TaskName}");
            }
        }

        public void MoveToNextTask()
        {
            if (current != null)
            {
                current = current.Next;
                ViewCurrentTask();
            }
        }

        public void DisplayTasks()
        {
            if (head == null) return;
            Task temp = head;
            while (temp.Next != head)
            {
                Console.Write($"{temp.TaskName}->");
                temp = temp.Next;
            }
            Console.WriteLine($"{temp.TaskName}");
        }

        public void SearchTaskByPriority(int priority)
        {
            if (head == null) return;
            Task temp = head;
            while (temp.Next != head)
            {
                if (temp.Priority == priority)
                {
                    Console.WriteLine($"Task ID: {temp.TaskID}, Name: {temp.TaskName}");
                }
                temp = temp.Next;
            }
            if (temp.Priority == priority)
            {
                Console.WriteLine($"Task ID: {temp.TaskID}, Name: {temp.TaskName}");
            }
        }

        public static void Main3()
        {
            Class3 scheduler = new Class3();
            scheduler.AddTaskAtBeginning(1, "Task 1", 2,"Today");
            scheduler.AddTaskAtEnd(2, "Task 2", 1, "Tomorrow");
            scheduler.AddTaskAtEnd(3, "Task 3", 3, "13/02/25");

            Console.WriteLine("All Tasks:");
            scheduler.DisplayTasks();

            Console.WriteLine("\nCurrent Task:");
            scheduler.ViewCurrentTask();

            Console.WriteLine("\nMoving to Next Task:");
            scheduler.MoveToNextTask();

            Console.WriteLine("\nSearch by Priority 1:");
            scheduler.SearchTaskByPriority(1);

            Console.WriteLine("\nRemoving Task 2:");
            scheduler.RemoveTask(2);
            scheduler.DisplayTasks();
        }
    }
}
