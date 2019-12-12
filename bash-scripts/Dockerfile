# Build from latest ubuntu image.
FROM ubuntu:latest

# Update package list
RUN apt-get update

# Install vim
RUN apt-get install -y vim

# Copy script files
COPY *-script ./

# Set default environment variable
ENV NAME=Joe

# Copy data files
COPY *.txt ./data/

# Run hello-file-script.
#CMD ["bin/bash", "/hello-file-script"]

# Entry point for args
ENTRYPOINT ["bin/bash", "/hello-args-script"]