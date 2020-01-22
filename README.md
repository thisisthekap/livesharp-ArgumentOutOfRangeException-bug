# livesharp-ArgumentOutOfRangeException-bug

## Issue

```
MSBUILD : Custom warning : LiveSharp exception: System.ArgumentOutOfRangeException: Specified argument was out of the range of valid values. [/reporoot/livesharp-ArgumentOutOfRangeException-bug/test.lib/test.lib.csproj]
MSBUILD : Custom warning :    at Mono.Collections.Generic.Collection`1.get_Item(Int32 index) [/reporoot/livesharp-ArgumentOutOfRangeException-bug/test.lib/test.lib.csproj]
MSBUILD : Custom warning :    at Mono.Cecil.BaseAssemblyResolver.GetAssemblyInNetGac(AssemblyNameReference reference, ReaderParameters parameters) [/reporoot/livesharp-ArgumentOutOfRangeException-bug/test.lib/test.lib.csproj]
MSBUILD : Custom warning :    at Mono.Cecil.BaseAssemblyResolver.GetAssemblyInGac(AssemblyNameReference reference, ReaderParameters parameters) [/reporoot/livesharp-ArgumentOutOfRangeException-bug/test.lib/test.lib.csproj]
MSBUILD : Custom warning :    at Mono.Cecil.BaseAssemblyResolver.Resolve(AssemblyNameReference name, ReaderParameters parameters) [/reporoot/livesharp-ArgumentOutOfRangeException-bug/test.lib/test.lib.csproj]
MSBUILD : Custom warning :    at Mono.Cecil.BaseAssemblyResolver.Resolve(AssemblyNameReference name) [/reporoot/livesharp-ArgumentOutOfRangeException-bug/test.lib/test.lib.csproj]
MSBUILD : Custom warning :    at Mono.Cecil.DefaultAssemblyResolver.Resolve(AssemblyNameReference name) [/reporoot/livesharp-ArgumentOutOfRangeException-bug/test.lib/test.lib.csproj]
MSBUILD : Custom warning :    at Mono.Cecil.MetadataResolver.Resolve(TypeReference type) [/reporoot/livesharp-ArgumentOutOfRangeException-bug/test.lib/test.lib.csproj]
MSBUILD : Custom warning :    at Mono.Cecil.ModuleDefinition.Resolve(TypeReference type) [/reporoot/livesharp-ArgumentOutOfRangeException-bug/test.lib/test.lib.csproj]
MSBUILD : Custom warning :    at Mono.Cecil.TypeReference.Resolve() [/reporoot/livesharp-ArgumentOutOfRangeException-bug/test.lib/test.lib.csproj]
MSBUILD : Custom warning :    at LiveSharp.BuildAgent.Building.CecilExtensions.GetBaseTypes(TypeDefinition type)+MoveNext() [/reporoot/livesharp-ArgumentOutOfRangeException-bug/test.lib/test.lib.csproj]
MSBUILD : Custom warning :    at System.Linq.Enumerable.Any[TSource](IEnumerable`1 source, Func`2 predicate) [/reporoot/livesharp-ArgumentOutOfRangeException-bug/test.lib/test.lib.csproj]
MSBUILD : Custom warning :    at LiveSharp.BuildAgent.Building.CecilExtensions.HasInterface(TypeDefinition typeDefinition, String interfaceFullName) [/reporoot/livesharp-ArgumentOutOfRangeException-bug/test.lib/test.lib.csproj]
MSBUILD : Custom warning :    at LiveSharp.BuildAgent.Building.LiveSharpContext.ProcessClientModule(ModuleDefinition module) [/reporoot/livesharp-ArgumentOutOfRangeException-bug/test.lib/test.lib.csproj]
MSBUILD : Custom warning :    at LiveSharp.BuildAgent.Building.Builder.ProcessEverything(Boolean isFullRebuild) [/reporoot/livesharp-ArgumentOutOfRangeException-bug/test.lib/test.lib.csproj]
```

When LiveSharp is disabled in test.lib.csproj using the `LIVESHARP_DISABLE` compilation symbol, the issue vanishes.

## Reproduction

1. `cd test.xunit`
2. `dotnet test`
