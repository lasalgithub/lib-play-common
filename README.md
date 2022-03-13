# Play Common

Common libraries for Play Hub Services

## Create and Publish package
```s
VERSION=1.7.0
OWNER="playhuborg"
GH_PAT=[GitHubToken]

dotnet pack --configuration Release -p:PackageVersion=$VERSION -p:RepositoryUrl=https://github.com/$OWNER/lib-play-common -o ../packages

dotnet nuget push ../packages/Play.Common.$VERSION.nupkg --api-key $GH_PAT --source "github"
```