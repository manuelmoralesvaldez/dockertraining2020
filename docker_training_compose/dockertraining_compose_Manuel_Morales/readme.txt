docker pull mysql
docker volume create db_data
docker run --name database_container -e MYSQL_RANDOM_ROOT_PASSWORD=yes -e MYSQL_DATABASE=personsdb -e MYSQL_USER=test -e MYSQL_PASSWORD=123456 -v db_data:/var/lib/mysql -p 3018:3306 -d mysql
docker-compose up
docker-compose down
docker-compose build
