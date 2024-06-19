# start from official image
FROM python:3.10-slim

# update OS
RUN apt-get update && apt-get upgrade -y 

# create working directory
RUN mkdir -p /code
WORKDIR /code

# install dependencies
COPY requirements.txt /code/
RUN pip install --no-cache-dir -r requirements.txt

# copy project code
COPY /trading_algorithm /code

# # change to non-root user 'app'
# RUN mkdir -p /home/app
# RUN addgroup --system app && adduser --system --group app
# RUN chown -R app:app /code
# USER app

# default commands to run when starting the container
CMD ["python", "make_trades.py"]
