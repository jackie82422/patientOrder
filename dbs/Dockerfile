FROM mysql:latest

ENV MYSQL_ROOT_PASSWORD=root_password
ENV MYSQL_DATABASE=patients_db
ENV MYSQL_USER=app_user
ENV MYSQL_PASSWORD=app_password

COPY init.sql /docker-entrypoint-initdb.d/

