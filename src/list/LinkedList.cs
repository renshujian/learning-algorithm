using System;

namespace Algorithm {

  public class LinkedList<T> {

    class Node {
      public T value {get; set;}
      public Node next {get; set;} = default!;
      public Node(T value) => this.value = value;
    }

    Node sentinel = new Node(default!);
    Node bottom;
    public int count {get; private set;}

    public LinkedList(params T[] values) {
      Node current = sentinel;
      foreach (T value in values) {
        current.next = new Node(value);
        current = current.next;
      }
      bottom = current;
      bottom.next = sentinel;
      count = values.Length;
    }

    public T this[int index] {
      get => getNode(index).value;
      set => getNode(index).value = value;
    }

    public void insert(int index, T value) {
      Node prev = getPrev(index);
      Node next = prev.next;
      prev.next = new Node(value);
      prev.next.next = next;
      count++;
      if (prev == bottom) {
        bottom = prev.next;
      }
    }

    public T delete(int index) {
      (Node prev, Node node) = getPrevAndNode(index);
      prev.next = node.next;
      count--;
      if (node == bottom) {
        bottom = prev;
      }
      return node.value;
    }

    public void enqueue(T value) => insert(count, value);

    public T dequeue() => delete(0);

    public void push(T value) => insert(0, value);

    public T pop() => delete(0);

    Node getNode(int index) {
      if (index < 0 || index >= count) throw new IndexOutOfRangeException();
      if (index == count - 1) return bottom;
      Node current = sentinel;
      for (int i = 0; i <= index; i++) {
        current = current.next;
      }
      return current;
    }

    Node getPrev(int index) {
      return index == 0 ? sentinel : getNode(index - 1);
    }

    (Node, Node) getPrevAndNode(int index) {
      Node prev = getPrev(index);
      Node node = prev.next;
      if (node == null) throw new IndexOutOfRangeException();
      return (prev, node);
    }
  }
}
