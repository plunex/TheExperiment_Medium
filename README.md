# Experiment

## run the command in the parent directory

docker build -f Experiment/Dockerfile -t the_experiment .

## stop the running container and run

docker run -d -p 5000:80 --name the_experiment_container the_experiment

### test the api. note: use http and not https
http://localhost:5000/Experiment/CarryOutExperiment1

http://localhost:5000/Experiment/CarryOutExperiment2

### stop the container
//

### build the project using docker compose
docker-compose build

### spin up the project using docker compose
docker-compose up

### test the api again
http://localhost:5000/Experiment/CarryOutExperiment1

http://localhost:5000/Experiment/CarryOutExperiment2