using System;

public class Task
{
    public int TaskID;
    public string TaskName;
    public int Priority;
    public DateTime DueDate;
    public Task next;

    public Task(int taskID, string taskName, int priority, DateTime dueDate)
    {
        TaskID = taskID;
        TaskName = taskName;
        Priority = priority;
        DueDate = dueDate;
        next = null;
    }

    public void DisplayTask()
    {
        Console.WriteLine($"TaskID: {TaskID}, TaskName: {TaskName}, Priority: {Priority}, DueDate: {DueDate.ToShortDateString()}");
    }
}

public class TaskScheduler
{
    private Task head;
    private Task current;

    public TaskScheduler()
    {
        head = null;
        current = null;
    }

    public void AddTaskAtBeginning(Task newTask)
    {
        if (head == null)
        {
            head = newTask;
            head.next = head;
        }
        else
        {
            Task temp = head;
            while (temp.next != head)
            {
                temp = temp.next;
            }
            newTask.next = head;
            temp.next = newTask;
            head = newTask;
        }
        Console.WriteLine("Task added at the beginning.");
    }

    public void AddTaskAtEnd(Task newTask)
    {
        if (head == null)
        {
            head = newTask;
            head.next = head;
        }
        else
        {
            Task temp = head;
            while (temp.next != head)
            {
                temp = temp.next;
            }
            temp.next = newTask;
            newTask.next = head;
        }
        Console.WriteLine("Task added at the end.");
    }

    public void AddTaskAtPosition(Task newTask, int position)
    {
        if (position == 0)
        {
            AddTaskAtBeginning(newTask);
            return;
        }

        Task temp = head;
        int index = 0;

        while (index < position - 1 && temp.next != head)
        {
            temp = temp.next;
            index++;
        }

        if (index != position - 1)
        {
            Console.WriteLine("Invalid position.");
            return;
        }

        newTask.next = temp.next;
        temp.next = newTask;
        Console.WriteLine($"Task added at position {position}.");
    }

    public void RemoveTaskByID(int taskID)
    {
        if (head == null)
        {
            Console.WriteLine("List is empty.");
            return;
        }

        if (head.TaskID == taskID)
        {
            if (head.next == head)
            {
                head = null;
            }
            else
            {
                Task temp = head;
                while (temp.next != head)
                {
                    temp = temp.next;
                }
                head = head.next;
                temp.next = head;
            }
            Console.WriteLine("Task removed successfully.");
            return;
        }

        Task current = head;
        while (current.next != head && current.next.TaskID != taskID)
        {
            current = current.next;
        }

        if (current.next == head)
        {
            Console.WriteLine("Task not found.");
        }
        else
        {
            current.next = current.next.next;
            Console.WriteLine("Task removed successfully.");
        }
    }

    public void ViewCurrentTask()
    {
        if (current == null)
        {
            current = head;
        }

        if (current != null)
        {
            Console.WriteLine("Current Task:");
            current.DisplayTask();
            current = current.next;
        }
        else
        {
            Console.WriteLine("No tasks available.");
        }
    }

    public void DisplayAllTasks()
    {
        if (head == null)
        {
            Console.WriteLine("No tasks to display.");
            return;
        }

        Console.WriteLine("Tasks in the list:");
        Task temp = head;
        do
        {
            temp.DisplayTask();
            temp = temp.next;
        } while (temp != head);
    }

    public void SearchTaskByPriority(int priority)
    {
        if (head == null)
        {
            Console.WriteLine("No tasks to search.");
            return;
        }

        bool found = false;
        Task temp = head;
        do
        {
            if (temp.Priority == priority)
            {
                temp.DisplayTask();
                found = true;
            }
            temp = temp.next;
        } while (temp != head);

        if (!found)
        {
            Console.WriteLine($"No tasks found with priority {priority}.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        TaskScheduler scheduler = new TaskScheduler();

        scheduler.AddTaskAtEnd(new Task(1, "Task A", 1, DateTime.Now.AddDays(1)));
        scheduler.AddTaskAtEnd(new Task(2, "Task B", 2, DateTime.Now.AddDays(2)));
        scheduler.AddTaskAtBeginning(new Task(3, "Task C", 1, DateTime.Now.AddDays(3)));
        scheduler.AddTaskAtPosition(new Task(4, "Task D", 3, DateTime.Now.AddDays(4)), 2);

        scheduler.DisplayAllTasks();
        Console.WriteLine();

        scheduler.ViewCurrentTask();
        scheduler.ViewCurrentTask();
        Console.WriteLine();

        scheduler.SearchTaskByPriority(1);
        Console.WriteLine();

        scheduler.RemoveTaskByID(2);
        scheduler.DisplayAllTasks();
    }
}
