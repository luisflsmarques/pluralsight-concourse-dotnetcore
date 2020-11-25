#!/bin/bash

dotnet publish ./source-code/pluralsight-concourse-dotnetcore.csproj -o .././compiled-app
tar -czvf ./packaged-core-app/app.tar.gz ./compiled-app
ls
cd packaged-core-app
ls  