using System;

namespace Algorithm {

  public class DoublyLinkedList<T> {

    class Node {
      public T value {get; set;}
      public Node next {get; set;} = default!;
      public Node prev {get; set;} = default!;
      public Node(T value) => this.value = value;
    }

    Node sentinel = new Node(default!);
    public int count {get; private set;}

    public DoublyLinkedList(params T[] values) {
      Node current = sentinel;
      Node prev = current;
      foreach (T value in values) {
        prev = current;
        current = new Node(value);
        prev.next = current;
        current.prev = prev;
      }
      current.next = sentinel;
      sentinel.prev = current;
      count = values.Length;
    }

    public T this[int index] {
      get => getNode(index).value;
      set => getNode(index).value = value;
    }

    public void insert(int index, T value) {
      Node prev = getPrev(index);
      Node next = prev.next;
      Node node = new Node(value);
      prev.next = node;
      node.prev = prev;
      node.next = next;
      next.prev = node;
      count++;
    }

    public T delete(int index) {
      Node node = getNode(index);
      Node prev = node.prev;
      Node next = node.next;
      prev.next = next;
      next.prev = prev;
      count--;
      return node.value;
    }

    public void lpush(T value) => insert(0, value);

    public T lpop() => delete(0);

    public void rpush(T value) => insert(count, value);

    public T rpop() => delete(count - 1);

    Node getNode(int index) {
      if (index < 0 || index >= count) throw new IndexOutOfRangeException();
      Node current = sentinel;
      if (index < count / 2) {
        for (int i = 0; i <= index; i++) {
          current = current.next;
        }
      } else {
        for (int i = count - 1; i >= index; i--) {
          current = current.prev;
        }
      }
      return current;
    }

    Node getPrev(int index) {
      return index == 0 ? sentinel : getNode(index - 1);
    }
  }
}
