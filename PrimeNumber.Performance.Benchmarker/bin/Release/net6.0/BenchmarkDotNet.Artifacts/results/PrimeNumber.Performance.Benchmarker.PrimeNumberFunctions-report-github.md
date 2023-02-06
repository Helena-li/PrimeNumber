``` ini

BenchmarkDotNet=v0.13.4, OS=macOS Monterey 12.3 (21E230) [Darwin 21.4.0]
Intel Core i9-9880H CPU 2.30GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK=6.0.100
  [Host]     : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT AVX2


```
|              Method |     Mean |    Error |   StdDev |
|-------------------- |---------:|---------:|---------:|
| CheckProduct_String | 47.50 ns | 0.839 ns | 1.447 ns |
|  CheckProduct_Char1 | 47.01 ns | 0.955 ns | 1.339 ns |
