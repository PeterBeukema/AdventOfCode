using System.Reflection;

using AdventOfCode;

var puzzles = Assembly.GetEntryAssembly()?.GetTypes()
    .Where(type => !type.IsAbstract)
    .Where(type => typeof(DailyPuzzle).IsAssignableFrom(type))
    .Select(type => (DailyPuzzle)Activator.CreateInstance(type)!)
    .OrderBy(puzzle => puzzle.Year)
    .ThenBy(puzzle => puzzle.Day)
    .ToList() ?? [];

foreach (var puzzle in puzzles)
{
    puzzle.Solve();
}