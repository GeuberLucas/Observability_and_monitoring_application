# Dockerfile for Prometheus
FROM prom/prometheus:v2.30.3

# Copy the Prometheus configuration file
COPY prometheus.yml /etc/prometheus/

# Expose the default Prometheus port
EXPOSE 9090

# Set the entry point to start Prometheus
ENTRYPOINT ["/bin/prometheus", "--config.file=/etc/prometheus/prometheus.yml"]