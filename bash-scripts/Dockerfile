# Build from latest ubuntu image.
FROM ubuntu:latest

# Copy script files
COPY *-script ./

# Set default environment variable
ENV NAME=Joe

# Copy data files
COPY *.txt ./data/

# Install vim
RUN apt-get update  &&\
    apt-get -y install vim

# Run hello-file-script.
CMD [ "/bin/bash", "/hello-file-script"]
