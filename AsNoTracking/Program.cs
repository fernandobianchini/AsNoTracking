using AsNoTracking;
using BenchmarkDotNet.Running;

var summary = BenchmarkRunner.Run<Benchmark>();