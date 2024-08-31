# Dockerfile for MySQL
FROM mysql/mysql-server:8.0.24

# Set environment variables for MySQL
ENV MYSQL_ROOT_PASSWORD="@d$]8~q4B]}@BcL)"
ENV MYSQL_DATABASE="ObservabilityDB"
ENV MYSQL_USER="api"
ENV MYSQL_PASSWORD="mysql123"

# Copy custom MySQL configuration
COPY my.cnf /etc/mysql/my.cnf

# Expose the custom MySQL port
EXPOSE 80

# Volume for MySQL data
VOLUME /var/lib/mysql

# Set the entry point to start MySQL
CMD ["mysqld"]

# You can change this to a newer version of MySQL available at
# https://hub.docker.com/r/mysql/mysql-server/tags/


COPY config/user.cnf /etc/mysql/my.cnf