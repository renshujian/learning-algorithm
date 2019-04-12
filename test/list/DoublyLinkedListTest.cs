using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithm {

  [TestClass]
  public class DoublyLinkedListTest {

    [TestMethod]
    public void crud() {
      var list = new DoublyLinkedList<int>(0,1,2,3,4);
      Assert.AreEqual(1, ++list[0]);
      list.insert(0, 0);
      Assert.AreEqual(6, list.count);
      list.delete(1);
      Assert.AreEqual(5, list.count);
    }

    [TestMethod]
    public void queue() {
      var data = new char[]{'a','b','c'};
      var queue = new DoublyLinkedList<char>();
      foreach (var datum in data) {
        queue.rpush(datum);
      }
      for(int i = 0; i < 3; i++) {
        data[i] = queue.lpop();
      }
      Assert.AreEqual('a', data[0]);
    }

    [TestMethod]
    public void stack() {
      var data = new char[]{'a','b','c'};
      var stack = new DoublyLinkedList<char>();
      foreach (var datum in data) {
        stack.rpush(datum);
      }
      for(int i = 0; i < 3; i++) {
        data[i] = stack.rpop();
      }
      Assert.AreEqual('c', data[0]);
    }

    [TestMethod]
    public void deque() {
      var data = new char[]{'a','b','c'};
      var deque = new DoublyLinkedList<char>();
      foreach (var datum in data) {
        deque.lpush(datum);
        deque.rpush(datum);
      }
      var ldata = new char[3];
      var rdata = new char[3];
      for(int i = 0; i < 3; i++) {
        ldata[i] = deque.lpop();
        rdata[i] = deque.rpop();
      }
      Assert.AreEqual('c', ldata[0]);
      Assert.AreEqual('a', rdata[2]);
    }
  }
}
