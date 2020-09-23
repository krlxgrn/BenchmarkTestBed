# BenchmarkTestBed

A template repository to quickly setup and run a BenchmarkDotNet performance benchmark.

`DefaultBenchmark.BenchmarkOne` - Add the code you want to benchmark here. 

`DefaultBenchmark.BenchmarkTwo` - When comparing two implementations, add the second implementation here. Otherwise, comment this method out.

To run the benchmark with fair results
- Close all other running programs.
- Connect the power cable if on a laptop.
- `dotnet run -c Release`