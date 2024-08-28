# Dockerfile for SQL Server
FROM mcr.microsoft.com/mssql/server:2022-latest

# Install the necessary packages
RUN apt-get update && apt-get install -y sudo
RUN useradd -m docker && echo "docker:docker" | chpasswd && adduser docker sudo
USER docker
# Set environment variables for SQL Server
ENV MSSQL_SA_PASSWORD=@d$]8~q4B]}@BcL)
ENV ACCEPT_EULA=Y
ENV MSSQL_PID=Express

# Expose the default SQL Server port
EXPOSE 1433

# Volume for SQL Server data
VOLUME /var/opt/mssql/data

# Copy the initialization script
COPY init-db.sh /usr/src/app/init-db.sh

# Ensure the script has execution permissions
RUN chmod +x /usr/src/app/init-db.sh

# Set the entry point to the initialization script
ENTRYPOINT ["/usr/src/app/init-db.sh"]