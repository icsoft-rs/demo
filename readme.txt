dotnet pack --configuration Release -p:IncludeSymbols=true -p:SymbolPackageFormat=snupkg
dotnet nuget push "bin\Release\Demo.Backend.1.0.0.nupkg"  --api-key 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 --source "github"
dotnet add package Demo.Backend -v 1.0.0
