#!/bin/bash

# Ensure the MSSQL data directory has the correct permissions
chown -R mssql:mssql /var/opt/mssql

# Start SQL Server
/opt/mssql/bin/sqlservr