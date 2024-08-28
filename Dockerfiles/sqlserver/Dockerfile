# Dockerfile for SQL Server
FROM mcr.microsoft.com/mssql/server:2022-latest


# Set environment variables for SQL Server
ENV MSSQL_SA_PASSWORD=@d$]8~q4B]}@BcL)
ENV ACCEPT_EULA=Y
ENV MSSQL_PID=Express

# Expose the default SQL Server port
EXPOSE 1433

# Volume for SQL Server data
VOLUME /var/opt/mssql/data

RUN chown -R mssql:mssql /var/opt/mssql

# Set the entry point to start SQL Server
CMD ["/opt/mssql/bin/sqlservr"]