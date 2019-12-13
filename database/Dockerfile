#docker run -e ACCEPT_EULA=Y -e SA_PASSWORD=Password1 -p 1433:1433 --rm --name -d sql-server mcr.microsoft.com/mssql/server:2019-latest

#/opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P "Password1"

#docker build -t custom-sql .

#docker run --rm -it --name sql-server -p 1433:1433 custom-sql


# Build from latest ubuntu image.
FROM mcr.microsoft.com/mssql/server:2019-latest

ENV ACCEPT_EULA=Y 
ENV SA_PASSWORD=Password1

# Copy SQL scripts
COPY *.sql ./sql-scripts/

# Run database build scripts
# Sleep for 30 seconds to make sure SQL has spun up.
RUN /opt/mssql/bin/sqlservr &\
    sleep 30s &&\
    /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P "Password1" -i ./sql-scripts/create-database.sql &&\
    /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P "Password1" -i ./sql-scripts/create-table.sql

CMD /opt/mssql/bin/sqlservr
