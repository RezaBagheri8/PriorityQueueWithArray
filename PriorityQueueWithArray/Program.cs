using PriorityQueueWithArray;

var queue = new PriorityQueue(4);

queue.Enqueue(10);
queue.Enqueue(3);
queue.Enqueue(8);
queue.Enqueue(4);
queue.Enqueue(4);


//queue.Dequeue();
//queue.Dequeue();
//queue.Dequeue();
//queue.Dequeue();
//queue.Dequeue();

Console.WriteLine("_________________________");

queue.Print();