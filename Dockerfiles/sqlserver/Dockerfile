# Dockerfile for MySQL
FROM mysql:8.0

# Set environment variables for MySQL
ENV MYSQL_ROOT_PASSWORD=rootpassword
ENV MYSQL_DATABASE=mydatabase
ENV MYSQL_USER=myuser
ENV MYSQL_PASSWORD=mypassword

# Expose the default MySQL port
EXPOSE 3306

# Volume for MySQL data
VOLUME /var/lib/mysql

# Set the entry point to start MySQL
CMD ["mysqld"]