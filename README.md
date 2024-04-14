### Running the Project with Docker Compose

To run the project, follow these steps:

#### Step 1: Install Docker and Docker Compose

Ensure that Docker and Docker Compose are installed on your system. You can find installation instructions at the following links:

- [Docker Official Website](https://docs.docker.com/get-docker/)
- [Docker Compose Official Website](https://docs.docker.com/compose/install/)

#### Step 2: Clone the Project Repository

Clone the project repository to your local environment. You can use the following command to clone the project from GitHub:
> git clone <repository_url>


#### Step 3: Run Docker Compose

Open a terminal in the root directory of the project and run the following command to start the project:
> docker-compose up --build

Using the `--build` option will build Docker images.

#### Step 4: Test the Application

Once the containers are successfully running, you can access the application in your browser. Open your browser and visit the following URL:

- Application: [http://localhost:80/swagger/index.html](http://localhost:80/swagger/index.html)

You can now begin using the application!

#### Step 5: Shut Down Docker Compose

To stop and remove all Docker containers, use the `Ctrl + C` key combination in the terminal and then run the following command:
> docker-compose down


This will stop and remove all associated Docker containers.

### Notes

- This project uses Docker Compose to manage the deployment and execution of containerized applications.
- The Docker Compose file defines the structure, services, and configuration of the application.
- By running the `docker-compose up` command, you can start all relevant containers at once.
- You can access the application in your browser by visiting `http://localhost:80`.
  
These are the basic steps for running the project. If you have any questions or concerns, feel free to reach out to me. Happy coding!

