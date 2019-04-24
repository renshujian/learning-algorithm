#!/bin/bash -eu
dotnet run -p benchmark -c Release -- "$@"
