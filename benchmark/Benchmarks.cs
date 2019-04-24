using BenchmarkDotNet.Running;

namespace Algorithm {

  class Benchmarks {

    static void Main(string[] args) {
      BenchmarkSwitcher.FromAssembly(typeof(Benchmarks).Assembly).Run(args);
    }
  }
}
