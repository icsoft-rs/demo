NUGET
Options/Debuger/Enable Just My Code => uncheck it
<DebugType>embedded</DebugType> => .csproj embedded symbols packages are the most straightforward and recommended approach. They include the PDB and DLL inside a single NuGet Package instead of needing to use separate packages.

--add nuget sources
dotnet nuget list source
dotnet nuget add source https://nexus.h14.dev22.rs/repository/nuget-group/index.json -n NexusNuGetGroup -u milos.cvetkovic -p Nexus --store-password-in-clear-text
dotnet nuget add source http://nexus.h14.dev22.rs/repository/nuget-hosted/index.json -n NexusNuGetHosted -u milos.cvetkovic -p Nexus --store-password-in-clear-text
dotnet nuget remove source NexusNuGetGroup
nuget setapikey 1ac1cff4-6d45-3917-bcea-4ab0faa9a481 -source http://nexus.h14.dev22.rs/repository/nuget-hosted/index.json

--pack and push
dotnet pack -c Release
dotnet nuget push "bin\Release\Demo.Backend.1.0.0.nupkg" -s http://nexus.h14.dev22.rs/repository/nuget-hosted/index.json

dotnet pack -p:IncludeSymbols=true -p:SymbolPackageFormat=snupkg --include-symbols -c release
dotnet nuget push "bin\Release\Demo.Backend.2.0.8.nupkg" -s http://nexus.h14.dev22.rs/repository/nuget-hosted/index.json
dotnet nuget push "bin\Release\Demo.Backend.2.0.8.snupkg" -s http://nexus.h14.dev22.rs/repository/nuget-hosted/index.json

--manage cache
dotnet nuget locals all -l
dotnet nuget locals all --clear (delete all cache)
dotnet nuget locals temp -c (delete specific cache)

