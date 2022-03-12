# Play Common

Common libraries for Play Hub Services

## Create and Publish package
```console
VERSION=1.6.0
OWNER="playhuborg"
dotnet pack --configuration Release -p:PackageVersion=$VERSION -p:RepositoryUrl=https://github.com/$OWNER/lib-play-common -o ../packages
```