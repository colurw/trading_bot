# start from official image
FROM python:3.10-slim

# update OS
RUN apt-get update && apt-get upgrade -y 

# create working directory
RUN mkdir -p /services
WORKDIR /services

# install dependencies
COPY requirements.txt /services/
RUN pip install --no-cache-dir -r requirements.txt

# copy project code
COPY . /services

# # change to non-root user 'app'
# RUN mkdir -p /home/app
# RUN addgroup --system app && adduser --system --group app
# RUN chown -R app:app /services
# USER app

# default commands to run when starting the container - start gunicorn server
CMD ["python", "make_trades.py", ]
