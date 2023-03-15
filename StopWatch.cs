var sw = System.Diagnostics.Stopwatch.StartNew(); // More performant than saying "new Stopwatch"
// 1 million iterations
for (int i = 0; i < 1000000; i++)
{ 
  // Do something expensive here
}
sw.Stop();
Debug.LogError($"Stopwatch took: {sw.ElapsedMilliseconds} ms");
