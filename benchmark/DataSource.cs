using System.IO;

namespace Algorithm {

  public static class DataSource {

    public static char[] lowCardinality(int length) {
      var data = new char[length];
      using(var reader = File.OpenText("data/pi-1million.txt")) {
        reader.Read(data);
      }
      return data;
    }

    public static char[] highCardinality(int length) {
      var data = new char[length];
      using(var reader = File.OpenText("data/bible.txt")) {
        reader.Read(data);
      }
      return data;
    }
  }

  public enum DataType {
    lowCardinality, highCardinality
  }
}
