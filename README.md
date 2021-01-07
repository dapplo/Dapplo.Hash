# Dapplo.Hash
Good performing hash routines


```
|                Method |        Job |       Runtime |     Mean |    Error |   StdDev |      Min |      Max | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------- |----------- |-------------- |---------:|---------:|---------:|---------:|---------:|------:|------:|------:|----------:|
| MurmurPerformanceTest | Job-UTBPBV |    .NET 4.7.2 | 59.24 ns | 0.214 ns | 0.190 ns | 58.89 ns | 59.54 ns |     - |     - |     - |         - |
| MurmurPerformanceTest | Job-NMVTLT | .NET Core 3.1 | 24.57 ns | 0.157 ns | 0.131 ns | 24.28 ns | 24.73 ns |     - |     - |     - |         - |
| MurmurPerformanceTest | Job-KNNBBD | .NET Core 5.0 | 23.92 ns | 0.208 ns | 0.174 ns | 23.69 ns | 24.36 ns |     - |     - |     - |         - |
```