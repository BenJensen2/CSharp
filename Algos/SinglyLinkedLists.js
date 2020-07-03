// Thur
// queueUsingTwoStacks
// create enqueue and dequeue methods on a new queue class that uses ONLY 2 stacks as storage but simulates a FIFO pattern
// sumOfHalvesEqual
// create a method on the array Queue class that returns whether or not the sum of the first half of the queue is equal to the sum of the second half
// DO NOT manually index the queue items, only use the provided queue methods, use no additional arrays or objects for storage
// restore the queue to it's original state before returning

class QueueArray {
    constructor() {
      this.queue = [];
    }
  
    compareQueues(queue2) {
      if (this.size() !== queue2.size()) {
        return false;
      }
      let front = this.front();
      let front2 = queue2.front();
      let length = this.size();
      let count = 0;
      let returnVal = true;
      while (count < length) {
        count++;
        if (front != front2) {
          returnVal = false;
        }
        this.enqueue(front);
        this.dequeue();
        front = this.front();
        queue2.enqueue(front2);
        queue2.dequeue();
        front2 = queue2.front();
        console.log(this.queue);
      }
      return returnVal;
    }
  
    enqueue(val) {
      this.queue.push(val);
      return this.queue;
    }
  
    dequeue() {
      // remove first item in queue and return it
      let removedItem = this.queue.shift();
      return removedItem;
    }
  
    isEmpty() {
      // check to see if queue is empty, boolean
      if (this.queue.length == 0) {
        return true;
      }
      return false;
    }
  
    size() {
      let length = this.queue.length;
      return length;
    }
  
    front() {
      let firstItem = this.queue[0];
      return firstItem;
    }
  }
  
  class QueueUsingTwoStacks {
    constructor() {
      this.stack1 = [];
      this.stack2 = [];
    }
  
    enqueue(val) {
      this.
    }
  }
  
  const arrayQueue = new QueueArray();
  const queue2 = new QueueArray();
  arrayQueue.enqueue(8);
  arrayQueue.enqueue(2);
  arrayQueue.enqueue(3);
  arrayQueue.enqueue(4);
  arrayQueue.enqueue(5);
  queue2.enqueue(1);
  queue2.enqueue(2);
  queue2.enqueue(3);
  queue2.enqueue(4);
  queue2.enqueue(5);
  console.log(arrayQueue.compareQueues(queue2));
  console.log("q1 " + arrayQueue.queue);
  console.log("q2 " + queue2.queue);
  
  class Node {
    constructor(data) {
      this.data = data;
      this.next = null;
    }
  }
  
  class QueueLinkedList {
    constructor() {
      this.head = null;
    }
    isEmpty() {
      return this.head === null;
    }
    seedFromArr(arr) {
      for (const elem of arr) {
        this.enqueue(elem);
      }
    }
    display() {
      let str = "";
  
      let runner = this.head;
  
      while (runner !== null) {
        str += runner.data;
  
        // add ", " if not last node
        if (runner.next !== null) {
          str += ", ";
        }
        runner = runner.next;
      }
      console.log(str);
      return str;
    }
    enqueue(val) {
      const newNode = new Node(val);
      if (this.isEmpty()) {
        this.head = newNode;
        return;
      }
      let runner = this.head;
      while (runner.next !== null) {
        runner = runner.next;
      }
      runner.next = newNode;
    }
    dequeue() {
      if (this.isEmpty()) {
        return null;
      }
      let removedHead = this.head;
      this.head = this.head.next;
      return removedHead;
    }
    size() {
      if (this.isEmpty()) {
        return 0;
      }
      let count = 0;
      let runner = this.head;
      while (runner !== null) {
        count++;
        runner = runner.next;
      }
      return count;
    }
    front() {
      if (this.isEmpty()) {
        return null;
      }
      return this.head;
    }
  }
  
  // const listQueue = new QueueLinkedList();
  // listQueue.seedFromArr([1, 2, 3, 4, 5]);
  // listQueue.display();
  // console.log(listQueue.dequeue());
  // listQueue.display();
  // console.log(listQueue.size());
  // console.log(listQueue.front());
  