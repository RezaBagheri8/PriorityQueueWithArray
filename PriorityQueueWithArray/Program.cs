using PriorityQueueWithArray;

var queue = new PriorityQueue(4);

queue.Enqueue(10, 1000);
queue.Enqueue(3, 50);
queue.Enqueue(8, 40);
queue.Enqueue(4, 30);
queue.Enqueue(4, 20);


queue.Dequeue();
queue.Print();
queue.Dequeue();
queue.Dequeue();
queue.Dequeue();
//queue.Dequeue();

Console.WriteLine("_________________________");

queue.Print();