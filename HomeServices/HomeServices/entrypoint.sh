#!/bin/bash
chmod +x ./entrypoint.sh

set -e
run_cmd="dotnet PeopleService.dll"

#until dotnet ef database update; do
#>&2 echo "SQL Server is starting up"
#sleep 1
#done


exec $run_cmd